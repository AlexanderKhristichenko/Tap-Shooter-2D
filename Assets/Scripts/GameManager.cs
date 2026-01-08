using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;
    bool gameStarted = false;

    [SerializeField] GameObject target;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnRate;
    [SerializeField] float maxPos;
    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] GameObject startScreen;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !gameStarted)
        {
            GameStart();

            gameStarted = true;
        }
    }

    public void GameStart()
    {
        InvokeRepeating("SpawnTarget", 1f, spawnRate);

        startScreen.SetActive(false);
        scoreText.gameObject.SetActive(true);
    }

    void SpawnTarget()
    {
        Vector3 spawnPos = spawnPoint.position;
        spawnPos.x = Random.Range(-maxPos, maxPos);

        Instantiate(target, spawnPos, Quaternion.identity);
    }

    public void GameScore()
    {
        score++;
        scoreText.text = score.ToString();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game");
    }
}
