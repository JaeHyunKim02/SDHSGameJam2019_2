using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{

    public Text t_MyScore;

    private float B_Hp;
    public float timer;
    public int Scoer;
    private void Start()
    {
        timer = 1.0f;
        Scoer = 0;


        
    }
    // Update is called once per frame
    void Update()
    {
        //t_HighestScore.text = "최고 점수: " + GameManager.GetInstance().MyScore;
       //HPBar.fillAmount = GameManager.GetInstance().Hp / 100f;
       // ConBar.fillAmount = GameManager.GetInstance().Condition / 100f;
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Scoer++;
            timer = 1.0f;

        }
        t_MyScore.text = "MyScoer:" + Scoer;
    }

}
