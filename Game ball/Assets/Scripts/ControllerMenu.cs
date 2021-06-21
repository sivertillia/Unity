using UnityEngine;
using UnityEngine.SceneManagement;

public class ControllerMenu : MonoBehaviour
{
    public GameObject buttonsMenu;
    public GameObject buttonsLevel;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NewGame()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Levels()
    {
        buttonsMenu.SetActive(false);
        buttonsLevel.SetActive(true);
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void LoadScene(string NameScene)
    {
        SceneManager.LoadScene(NameScene);
    }

    public void BackInMenu()
    {
        buttonsMenu.SetActive(true);
        buttonsLevel.SetActive(false);
    }
}
