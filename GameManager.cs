using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI livesText;
    public GameObject levelExit;

    private int score = 0;
    private int lives = 3;
    private int totalCollectibles;
    private int collectedCount = 0;

    void Awake()
{
    if (Instance == null)
    {
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    else
    {
        Destroy(gameObject);
        return;
    }
}

    void Start()
    {
        totalCollectibles = FindObjectsByType<Collectible>(FindObjectsSortMode.None).Length;
        if (levelExit != null)
            levelExit.SetActive(false);
    }

    public void AddScore(int points)
    {
        score += points;
        if (scoreText != null)
            scoreText.text = "Pontos: " + score;
        collectedCount++;

        if (collectedCount >= totalCollectibles)
        {
            if (levelExit != null)
                levelExit.SetActive(true);
        }
    }

    public void LoseLife()
    {
        lives--;
        if (livesText != null)
            livesText.text = "Vidas: " + lives;
    }
}