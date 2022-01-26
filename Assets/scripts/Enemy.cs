using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public void takeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.tag == "player")
        {
            Time.timeScale = 0.0f;

            LoadScene("gameOver");
        }
    }
    
    void LoadScene(string gameOver)
    {
        SceneManager.LoadScene(gameOver);
    }
}
