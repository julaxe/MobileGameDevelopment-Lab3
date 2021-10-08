using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Header("Bullet Movement")]
    [Range(0.0f, 0.5f)]
    public float speed;
    public Bounds bulletBounds;

    private BulletManager bulletManager;

    // Start is called before the first frame update
    void Start()
    {
        bulletManager = GameObject.FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Move();
        CheckBounds();
    }

    private void Move()
    {
        transform.position -= new Vector3(0.0f, speed, 0.0f);
    }

    private void CheckBounds()
    {
        if (transform.position.y < bulletBounds.max)
        {
            //Destroy(this.gameObject);

            bulletManager.ReturnBullet(this.gameObject);
        }
    }
}
