using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public int health = 1;
    public GameObject deathParticle;
    public void takeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            Instantiate(deathParticle, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.tag == "player")
        {
            Instantiate(deathParticle, transform.position, Quaternion.identity);

            LoadScene("gameOver");
        }
    }
    
    void LoadScene(string gameOver)
    {
        SceneManager.LoadScene(gameOver);
    }
}
