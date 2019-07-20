using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pause : MonoBehaviour
{
    public GameObject PauseUI;

    private bool isPause = false;

    // Start is called before the first frame update
    void Start()
    {
        PauseUI.SetActive(false);

    }

    private void Update()
    {
        if (isPause)
        {
            PauseUI.SetActive(true);
            Time.timeScale = 0f;

        }
        else if (!isPause)
        {
            PauseUI.SetActive(false);
            Time.timeScale = 1f;
        }
    }
    public void PauseButton()
    {
        if (!isPause)
            isPause = true;
        else if (isPause)
            isPause = false;
    }

 
}
