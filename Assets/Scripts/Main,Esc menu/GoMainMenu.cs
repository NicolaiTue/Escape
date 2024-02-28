using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class GoMainMenu : MonoBehaviour
{
    public void play()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
