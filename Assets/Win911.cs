using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Win911 : MonoBehaviour
{

    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Win911")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
           
        }
    }
    
}
