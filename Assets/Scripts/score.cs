using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class score : MonoBehaviour
{

    
    Text ScoreText;
    int myScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        ScoreText = GetComponent<Text>();
        UpdateScore(0);   
    }

    public void UpdateScore(int value)
    {
        myScore += value;
        ScoreText.text =  myScore.ToString();
        if (myScore == 8)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
   
}
