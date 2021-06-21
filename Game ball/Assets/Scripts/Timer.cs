using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public Text textTimer;
    private int sec = 0;
    private int min = 0;
    // Start is called before the first frame update
    void Start()
    {
        // textTimer.text = timeStart.ToString("F2");
        StartCoroutine(TimeFlow());
    }

    // Update is called once per frame
    IEnumerator TimeFlow()
    {
        while (true)
        {
            if (sec == 59)
            {
                min++;
                sec = -1;
            }
            sec++;
            textTimer.text = min.ToString("D2") + ":" + sec.ToString("D2");
            yield return new WaitForSeconds(1);
        }
    }
}
