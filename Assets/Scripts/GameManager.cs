using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public int MyScore=0;

    public int Hp = 100;
    public int Condition = 100;
    public bool HitPlayer;

    public Image HPBar;
    public Image SPBar;

    public bool isDie= false;

    private static GameManager instnce;
    public static GameManager GetInstance()//싱글톤
    {
        if (instnce == null)
        {
            instnce = FindObjectOfType<GameManager>();
            if (instnce == null)
            {
                GameObject container = new GameObject("GameManager");
                container.AddComponent<GameManager>();

            }
        }
        return instnce;

    }
    private void Awake()
    {
        MyScore = PlayerPrefs.GetInt("MyScore");//최고 점수 불러오기
    }

    public void SaveScore(int NewScore)
    {
        MyScore = NewScore;
        PlayerPrefs.SetInt("MyScore", MyScore);//최고 점수 저장
    }
    void EndGame()
    {
        if(HPBar.fillAmount == 0.0f || SPBar.fillAmount == 0.0f)
        {

        }
        
    }


}
