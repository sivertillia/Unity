using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SkinController : MonoBehaviour
{
    public GameObject SkinMenu;
    public Text CoinsText;
    public Material material;

    public string[] color;

    private int Coin;
    private Color startColor;

    public void Start()
    {
        startColor = material.GetColor("_Color");
        // ec = GetComponent<EditColor>();

        color = new string[5] { "red", "green", "blue", "black", "white" };

        Coin = PlayerPrefs.GetInt("coins", Coin);
        CoinsText.text = "Монеты: " + Coin.ToString();
    }
    public void selectColor(int colorId)
    {
        
        Color newColor;
        ColorUtility.TryParseHtmlString(color[colorId], out newColor);
        EditColorMaterial(newColor);
    }

    public void BackInMenu()
    {
        SceneManager.LoadScene("Main");
        EditColorMaterial(startColor);
    }
    public void SaveSkin()
    {
        Coin -= 10;
        if (Coin < 0)
        {
            Debug.Log("Нет денег");
        }
        else
        {
            PlayerPrefs.SetInt("coins", Coin);
            SceneManager.LoadScene("Main");
        }
    }


    public void EditColorMaterial(Color color)
    {
        // for 
        Debug.Log("Test: " + color);
        material.SetColor("_Color", color);
    }
}
