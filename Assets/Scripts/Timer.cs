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
        // Opdater timeren nedtælling
        timer -= Time.deltaTime;

        // Tjek om tiden er udløbet
        if (timer <= 0f)
        {
            // Udfør handlingen
            HandleTimerComplete();

            // Nulstil timeren til den oprindelige varighed for gentagne brug
            timer = timerDuration;
        }
    }

    void HandleTimerComplete()
    {
        // Udfør  handling her
        Debug.Log("Timeren er udløbet! Udfør handlingen her.");
    }
}
