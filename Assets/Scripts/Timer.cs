using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    
    public float timerDuration = 10f; // tid i sek
    private float timer;

    void Start()
    {
        timer = timerDuration;
    }

    void Update()
    {
        // Opdater timeren nedt�lling
        timer -= Time.deltaTime;

        // Tjek om tiden er udl�bet
        if (timer <= 0f)
        {
            // Udf�r handlingen
            HandleTimerComplete();

            // Nulstil timeren til den oprindelige varighed for gentagne brug
            timer = timerDuration;
        }
    }

    void HandleTimerComplete()
    {
        // Udf�r  handling her
        Debug.Log("Timeren er udl�bet! Udf�r handlingen her.");
    }
}
