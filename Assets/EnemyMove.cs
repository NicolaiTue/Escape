using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class EnemyMove : MonoBehaviour
{
    NavMeshAgent agent;
    public Transform target;

    public Transform[] patrolPoints;
    public float moveSpeed = 2f;

    private int currentPatrolIndex = 0;

    public float detectionRange = 10f;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

    }


    void Update()
    {

        float distanceToTarget = Vector3.Distance(transform.position, target.position);

        if (distanceToTarget < detectionRange && !IsObstacleBetweenEnemyAndTarget())
        {
            // Følg kun målet, hvis det er inden for synsfeltet og der er ingen forhindringer
            agent.SetDestination(target.position);
        }
        else
        {
            Patrol();
            
        }

    }

    bool IsObstacleBetweenEnemyAndTarget()
    {
        RaycastHit hit;

        // Udfør raycasting fra fjenden mod målet
        if (Physics.Raycast(transform.position, target.position - transform.position, out hit, detectionRange))
        {
            // Hvis raycast rammer noget, og det ikke er målet, returner true (der er en forhindring)
            if (hit.transform != target)
            {
                return true;
            }
        }

        // Ingen forhindringer
        return false;
    }



    void Patrol()
    {
        transform.LookAt(patrolPoints[currentPatrolIndex].position);
        // Bevæg AI mod det aktuelle patruljepunkt
        transform.position = Vector3.MoveTowards(transform.position, patrolPoints[currentPatrolIndex].position, moveSpeed * Time.deltaTime);

        // Hvis AI når patruljepunktet, skift til næste patruljepunkt
        if (Vector3.Distance(transform.position, patrolPoints[currentPatrolIndex].position) < 0.5f)
        {
            currentPatrolIndex = (currentPatrolIndex + 1) % patrolPoints.Length;
        }
    }




}