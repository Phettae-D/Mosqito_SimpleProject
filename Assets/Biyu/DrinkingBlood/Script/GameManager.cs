using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float score;
    public TextMeshProUGUI scoretext;
    public GameObject DangerUI;
    private void Awake()
    {
        instance = this;
    }
    public void setscore(float sc)
    {
        score += sc;
        scoretext.text = "Score: "+ score.ToString();
    }
}
