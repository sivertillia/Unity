using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skin : MonoBehaviour
{

    public Material carColor;
    public string[] availableColors;
    public string[] rainbowColors;

    private bool rainbowColor = true;
    private byte r = 0;
    private byte g = 0;
    private byte b = 0;

    private Color _rainbowColorCurrent = new Color(0, 0, 0);
    private Color _rainbowColorTarget = new Color(0, 0, 0);
    private float _rainbowColorLerpUnclampedT = 0f;

    private bool rainbowOnce = false;

    private KeyCode[] keyCodes = {
         KeyCode.Alpha1,
         KeyCode.Alpha2,
         KeyCode.Alpha3,
         KeyCode.Alpha4,
         KeyCode.Alpha5,
         KeyCode.Alpha6,
         // KeyCode.Alpha7,
         // KeyCode.Alpha8,
         // KeyCode.Alpha9,
     };

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < keyCodes.Length; i++)
        {
            if (Input.GetKeyDown(keyCodes[i]))
            {
                if (i == 5 && !rainbowOnce && !rainbowColor)
                {
                    rainbowColor = true;
                    _rainbowColorCurrent = carColor.color;
                }
                else if (!rainbowOnce)
                {
                    rainbowColor = false;

                    Color newColor;
                    ColorUtility.TryParseHtmlString(availableColors[i], out newColor);

                    _rainbowColorCurrent = carColor.color;
                    _rainbowColorTarget = newColor;
                    rainbowOnce = true;
                }
            }
        }

        if (rainbowColor || rainbowOnce)
        {
            if (_rainbowColorLerpUnclampedT >= 1.0f)
            {
                if (rainbowOnce)
                {
                    _rainbowColorLerpUnclampedT = 0.0f;
                    rainbowOnce = false;
                    return;
                }

                // pick new
                Color randomColor = _rainbowColorTarget;
                while (randomColor == _rainbowColorTarget)
                {
                    // pick unique random new color
                    ColorUtility.TryParseHtmlString(rainbowColors[Random.Range(0, rainbowColors.Length)], out randomColor);
                }

                _rainbowColorTarget = randomColor;
                _rainbowColorLerpUnclampedT = 0f;

                _rainbowColorCurrent = carColor.color;

                Debug.Log("New color picked!");
            }

            // translate to target color gradually
            _rainbowColorLerpUnclampedT += 0.005f;
            carColor.color = Color.LerpUnclamped(_rainbowColorCurrent, _rainbowColorTarget, _rainbowColorLerpUnclampedT);
        }
    }
}