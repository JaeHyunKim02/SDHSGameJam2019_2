using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoIngame : MonoBehaviour
{

    public void GoInGame()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void ReStart()
    {
        SceneManager.LoadScene("TestScene");
    }
}
