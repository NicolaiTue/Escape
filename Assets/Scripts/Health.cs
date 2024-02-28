using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHP = 3;
    public int currentHP;

    // Start is called before the first frame update
    void Start()
    {
        currentHP = maxHP;
    }

    // Update is called once per frame
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            currentHP = (currentHP - 1);
            FindObjectOfType<HealthBar>().UpdateHealth(1);
            if (currentHP <= 0)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }



}
