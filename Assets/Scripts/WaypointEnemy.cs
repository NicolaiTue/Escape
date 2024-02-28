using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointEnemy : MonoBehaviour
{

    public Transform[] Waypoints;
    public float distanceToSwapWP = 0.25f;
    public float speed = 3f;
    int nextWaypoint = 0;
    Rigidbody2D rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        transform.position = Waypoints[0].position; 
    }

    // Update is called once per frame
    void FixedUpdate() 
    {
        Vector2 direction = Waypoints[nextWaypoint].position - transform.position;
        if (direction.sqrMagnitude < distanceToSwapWP)
        {
            nextWaypoint = (nextWaypoint + 1) % Waypoints.Length;
        }
        rb.velocity = direction.normalized * speed;
    }
}
