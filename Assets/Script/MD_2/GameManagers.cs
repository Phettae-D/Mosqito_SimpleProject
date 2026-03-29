using TMPro;
using UnityEngine;

public class GameManagers : MonoBehaviour
{
    public static GameManagers instance;

    [Header("Game Setting")]
    public int score;

    [Header("Referent")]
    public TextMeshProUGUI scoreText;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Update()
    {
        UpdateUI();
    }

    public void UpdateUI() {
        scoreText.text = "Score: " + score.ToString();
    }

    public void GetScore(int amount) {
        score += amount;
        UpdateUI();
    }
}
