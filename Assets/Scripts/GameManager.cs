using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;

    void Awake()
    {
        instance = this;
    }

    public void GameStart()
    {

    }

    public void GameScore()
    {
        score++;
        print(score);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game");
    }
}
