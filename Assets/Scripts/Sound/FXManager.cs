using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FXManager : MonoBehaviour
{
    public AudioClip Touch;
    public AudioClip WindowOff;

    public AudioSource audio_F;

    private void Awake()
    {
        if (!PlayerPrefs.HasKey("FXProgress"))
            PlayerPrefs.SetFloat("FXProgress", 1f);
    }
    void Start()
    {

    }

    void Update()
    {

        audio_F.volume = PlayerPrefs.GetFloat("FXProgress", default);
    }

    public void SoundManager_F(string audioName)
    {

        if (audioName == "Touch")
        {
            audio_F.PlayOneShot(Touch);
        }

        if (audioName == "WindowOff")
        {
            audio_F.PlayOneShot(WindowOff);
        }
    }
}
