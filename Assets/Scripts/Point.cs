using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    int value = 1;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.tag == "Player")
        {
            FindObjectOfType<score>().UpdateScore(value);
            Destroy(gameObject);
        }

    }
}
