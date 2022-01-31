using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class win : MonoBehaviour
{

    public GameObject winScreen;
    bool isWin = false;

    void OnTriggerEnter2D(Collider2D otherObject)
    {
        if(otherObject.tag == "player")
        {
            Time.timeScale = 0.0f;
            winScreen.SetActive(true);

        }
    }
}
