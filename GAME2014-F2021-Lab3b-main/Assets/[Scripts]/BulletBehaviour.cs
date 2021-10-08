using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    [Header("Bullet Movement")]
    [Range(-0.5f, 0.5f)]
    public float speed;
    public Bounds bulletBounds;
    public bool isPlayerBullet = false;

    private BulletManager bulletManager;

    private void Start()
    {
        if (isPlayerBullet)
        {
            bulletManager = GameObject.Find("PlayerBullets").GetComponent<BulletManager>();
        }
        else
        {
            bulletManager = GameObject.Find("GameController").GetComponent<BulletManager>();
        }
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
            bulletManager.ReturnBullet(this.gameObject);
        }
        if (transform.position.y > bulletBounds.min)
        {
            bulletManager.ReturnBullet(this.gameObject);
        }
    }
}
