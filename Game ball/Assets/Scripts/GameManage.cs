using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManage : MonoBehaviour
{
    public GameObject PauseMenu;
    public GameObject DierMenu;
    public GameObject EndMenu;

    public Text deadScoreText;

    private int deadScore;
    private int tempDeadScore;
    private string lvlName;
    private string tempLvlName;

    // public GameObject MainCan;

    public void Start()
    {
        lvlName = "Dead-" + SceneManager.GetActiveScene().name.ToString();
        deadScore = PlayerPrefs.GetInt(lvlName);

        tempLvlName = "DeadTemp-" + SceneManager.GetActiveScene().name.ToString();
        tempDeadScore = PlayerPrefs.GetInt(tempLvlName);

        deadScoreText.text = "Смерти: " + tempDeadScore.ToString();
    }

    public void EndGame()
    {
        Freez();
        tempDeadScore += 1;
        PlayerPrefs.SetInt(tempLvlName, tempDeadScore);
        PauseMenu.SetActive(false);
        EndMenu.SetActive(false);
        DierMenu.SetActive(true);
    }

    public void FinishLevel()
    {
        Freez();
        if(deadScore == 0 || tempDeadScore <= deadScore)
        {
            PlayerPrefs.SetInt(lvlName, tempDeadScore);
        }
        PlayerPrefs.SetInt(tempLvlName, 0);

        int Coin = PlayerPrefs.GetInt("coins");
        Coin += 10;
        PlayerPrefs.SetInt("coins", Coin);
        PauseMenu.SetActive(false);
        DierMenu.SetActive(false);
        EndMenu.SetActive(true);
    }

    public void Pause()
    {
        Freez();
        EndMenu.SetActive(false);
        DierMenu.SetActive(false);
        PauseMenu.SetActive(true);
    }

    public void Freez()
    {
        Time.timeScale = 0;
    }
}
