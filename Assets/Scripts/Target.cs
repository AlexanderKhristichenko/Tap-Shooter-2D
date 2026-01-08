using UnityEngine;

public class Target : MonoBehaviour
{
    void Start()
    {

    }

    void Update()
    {
        if (transform.position.y <= -7f)
        {
            GameManager.instance.GameOver();
        }
    }

    void OnMouseDown()
    {
        GameManager.instance.GameScore();

        Destroy(gameObject);
    }
}
