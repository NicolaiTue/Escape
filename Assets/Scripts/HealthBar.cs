using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Text Healthbar;
    int myHealth = 3;

    // Start is called before the first frame update
    void Start()
    {
        Healthbar = GetComponent<Text>();
        UpdateHealth(0);
    }

    public void UpdateHealth(int value)
    {
        myHealth -= value;
        Healthbar.text = myHealth.ToString();
    }

}
