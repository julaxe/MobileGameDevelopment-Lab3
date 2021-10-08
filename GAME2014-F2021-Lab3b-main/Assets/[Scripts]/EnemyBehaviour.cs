using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviour : MonoBehaviour
{
    [Header("Enemy Movement")] 
    public Bounds movementBounds;
    public Bounds startingRange;

    [Header("Bullets")] 
    public Transform bulletSpawn;
    //public GameObject bulletPrefab;
    public int frameDelay;

    private float startingPoint;
    private float randomSpeed;
    private BulletManager bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        randomSpeed = Random.Range(movementBounds.min, movementBounds.max);
        startingPoint = Random.Range(startingRange.min, startingRange.max);
        bulletManager = GameObject.FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector2(Mathf.PingPong(Time.time, randomSpeed) + startingPoint, transform.position.y);
    }

    void FixedUpdate()
    {
        if (Time.frameCount % frameDelay == 0)
        {
            //var temp_bullet = Instantiate(bulletPrefab);
            //temp_bullet.transform.position = bulletSpawn.position;

            bulletManager.GetBullet(bulletSpawn.position);
        }
    }
}
