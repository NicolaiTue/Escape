using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public float countdownTime = 120f; // Angiv den ønskede tid i sekunder
    private float currentTime;
    private bool timerIsRunning = true;
    public TextMeshProUGUI timerText;

    private void Start()
    {
        currentTime = countdownTime;
    }

    private void Update()
    {
        if (timerIsRunning)
        {
            UpdateTimer();
        }
    }

    void UpdateTimer()
    {
        currentTime -= Time.deltaTime;

        // Opdater UI-tekst for at vise tiden i minutter og sekunder
        int minutes = Mathf.FloorToInt(currentTime / 60f);
        int seconds = Mathf.FloorToInt(currentTime % 60f);
        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);

        if (currentTime <= 0f)
        {
            currentTime = 0f;
            timerIsRunning = false;
            HandleTimerEnd(); // Kald din funktion for handling af tidsslutningen her
        }
    }

    void HandleTimerEnd()
    {
        // Udfør handlingen, f.eks. ændr spiltilstand, vis en besked, osv.
        Debug.Log("Tiden er udløbet! Udfører handlingen nu.");
        currentTime = countdownTime;
    }
}
