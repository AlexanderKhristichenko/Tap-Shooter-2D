using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    int score = 0;

    [SerializeField] GameObject target;
    [SerializeField] Transform spawnPoint;
    [SerializeField] float spawnRate;
    [SerializeField] float maxPos;

    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        GameStart();
    }

    public void GameStart()
    {
        InvokeRepeating("SpawnTarget", 1f, spawnRate);
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
        print(score);
    }

    public void GameOver()
    {
        SceneManager.LoadScene("Game");
    }
}
