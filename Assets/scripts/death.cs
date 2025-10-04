using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public float fallLimit = -5f; // Negative makes more sense for falling

    void Update()
    {
        // Reload if player falls below the set limit
        if (transform.position.y < fallLimit)
        {
            ReloadLevel();
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        // Reload if player touches a hazard
        if (other.CompareTag("Hazard"))
        {
            ReloadLevel();
        }
    }

    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
