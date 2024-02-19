using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Popup : MonoBehaviour
{
    public GameObject Dead;
    public float delayInSeconds = 10f;

    void Start()
    {
        Dead.gameObject.SetActive(false);
        // Invoke the method to show the text after a delay
        Invoke("ShowPopupText", delayInSeconds);
    }

    void ShowPopupText()
    {
        // Set the text as active or enable any other relevant behavior
        Dead.gameObject.SetActive(true);
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}

