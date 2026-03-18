using System.Data;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float score;
    public int time_M,time_S;
    public int time;
    public TextMeshProUGUI scoretext,TimeUI;
    public GameObject DangerUI,DeathUI,TimeOutUI;
    public PlayerMain player;
    private void Awake()
    {
        time = (time_M) * 60 + time_S;
        InvokeRepeating("Settime",0,0);
        instance = this;
    }
    private void Start()
    {
        GameOver();
    }
    public void Settime()
    {
        time -= 1;
        TimeUI.text = (time / 60).ToString()+":"+(time % 60).ToString();
        if (time <= 0)
        {
            TimeOut();
        }
    }
    public void setscore(float sc)
    {
        score += sc;
        scoretext.text = "Score: "+ score.ToString();
    }
    public void GameOver()
    {
        player.Death = true;
        DeathUI.SetActive(true);
        CancelInvoke("Settime");
        Invoke("RestartAble",1);
    }
    public void TimeOut()
    {
        TimeOutUI.SetActive(true);
        Invoke("RestartAble", 1);
    }
    public void RestartAble()
    {
        player.RestartAble = true;
    }
}
