using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class closeWindow : MonoBehaviour
{
    public GameObject OptionWindow;

    public void closeOption()
    {
        OptionWindow.SetActive(false);

    }
}
