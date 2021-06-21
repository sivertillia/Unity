using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LevelController : MonoBehaviour
{

    public GameObject DierGame;
    public GameObject PauseGame;
    public GameObject EndGame;

    // private int sceneAc;

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Resume()
    {
        PauseGame.SetActive(false);
        Time.timeScale = 1;
    }

    public void NextLevel()
    {
        Time.timeScale = 1;
        // SceneManager.LoadScene()
        if(SceneManager.GetActiveScene().buildIndex + 1 != SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        }
        else
        {
            SceneManager.LoadScene("Main");
        }

    }

    public void BackInMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }
}
