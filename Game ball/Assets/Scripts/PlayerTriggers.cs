using UnityEngine;

public class PlayerTriggers : MonoBehaviour
{
    public GameManage gm;

    private bool dierGame = true;
    private bool escPause = false;
    void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Finish")
        {
            gm.FinishLevel();
        }
        if (collision.collider.tag == "Kill")
        {
            gm.EndGame();
        }
    }

    void Update()
    {
        if(transform.position.y < -5f)
        {
            if (dierGame)
            {
                gm.EndGame();
                dierGame = false;
            }
        }
        if (Input.GetKeyDown("escape"))
        {
            gm.Pause();
        }
    }
}
