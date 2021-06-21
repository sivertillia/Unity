using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class SkinController : MonoBehaviour
{
    public GameObject SkinMenu;
    public GameObject cm;
    public Text CoinsText;
    
    public Material material;

    private int Coin;
    private Color startColor;

    void Start()
    {
        startColor = material.GetColor("_Color");

        Coin = PlayerPrefs.GetInt("coins", Coin);
        CoinsText.text = "Монеты: " + Coin.ToString();
    }

    public void ColorMenu()
    {
        cm.SetActive(true);
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
