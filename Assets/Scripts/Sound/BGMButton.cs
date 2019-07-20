using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BGMButton : MonoBehaviour
{
    public Image BGMOn;
    public Image BGMOff;

    float BGMProgress = 0.0f;

    // Start is called before the first frame update
    void Awake()
    {
        BGMProgress = PlayerPrefs.GetFloat("BGMProgress", default);

    }

    // Update is called once per frame
    public void BGM_Button()
    {
        if (BGMProgress == 1) BGMProgress = 0;
        if (BGMProgress == 0) BGMProgress = 1;
        PlayerPrefs.SetFloat("BGMProgress", BGMProgress);
    }
}
