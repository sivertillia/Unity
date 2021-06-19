using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    // public PlayerMovement movement;
    public float levelRestartDaly = 1f;

    public void EndGame()
    {
        // movement.enabled = false;
        Invoke("RestartLevel", levelRestartDaly);
    }

    public void FinishLevel()
    {
        NextLevel();
    }

    void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    void NextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
