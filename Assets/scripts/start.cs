using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class start : MonoBehaviour
{
    public void Quit()
    {
        Application.Quit();
    }
    public void ButtonMoveScene(string level)
    {
        SceneManager.LoadScene(level);
    }
}
