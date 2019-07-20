using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXButton : MonoBehaviour
{
    float FXProgress = 0f;
    // Start is called before the first frame update
    void Awake()
    {
        if (!PlayerPrefs.HasKey("FXProgress"))
            PlayerPrefs.SetFloat("FXProgress", 1f);
    }

    // Update is called once per frame
    void Start()
    {
        FXProgress = PlayerPrefs.GetFloat("FXProgress", default);
    }
    public void FX_Button()
    {
        if (FXProgress == 0) FXProgress = 1.0f;
        else if (FXProgress == 1) FXProgress = 0.0f;

        PlayerPrefs.SetFloat("FXProgress", FXProgress);
    }
}
