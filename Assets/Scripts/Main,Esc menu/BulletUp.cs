using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed = 5.0f;
    private Rigidbody2D bullet;


    void Start()
    {
        bullet = this.GetComponent<Rigidbody2D>();
        bullet.velocity =Vector2.up * Speed; 
    }

}