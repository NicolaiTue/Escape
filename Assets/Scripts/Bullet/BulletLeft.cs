using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLeft : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody2D bullet;


    void Start()
    {
        bullet = this.GetComponent<Rigidbody2D>();
        bullet.velocity = Vector2.left * Speed;
    }

    private void OnCollisionEnter2D(Collision2D collision) 
    {
        if (collision.gameObject.tag == "Player")
            Destroy(gameObject);
        
        if (collision.gameObject.tag == "Mur")
            Destroy(gameObject);

    }

}
