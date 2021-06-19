using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public GameManage gm;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Finish")
        {
            gm.FinishLevel();
        }
    }

    void Update()
    {
        if(transform.position.y < -5f)
        {
            gm.EndGame();
        }
    }
}
