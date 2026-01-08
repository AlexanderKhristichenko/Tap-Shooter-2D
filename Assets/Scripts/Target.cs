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
            Debug.Log("Game Over!");
        }
    }

    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
