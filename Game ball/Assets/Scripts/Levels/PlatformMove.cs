using UnityEngine;

public class PlatformMove : MonoBehaviour
{

    public float speed = 3f;

    public bool moveX = false;
    public bool moveY = false;
    public bool moveZ = false;

    private bool moveingRight = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {

        if (moveX)
        {
            if (transform.position.x > 4f)
            {
                moveingRight = false;
            }
            else if (transform.position.x < -4f)
            {
                moveingRight = true;
            }

            if (moveingRight)
            {
                transform.position = new Vector3(transform.position.x + speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x - speed * Time.deltaTime, transform.position.y, transform.position.z);
            }

        }

        else if (moveY)
        {
            if (transform.position.y > 5f)
            {
                moveingRight = false;
            }
            else if (transform.position.y < -0.1f)
            {
                moveingRight = true;
            }

            if (moveingRight)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y + speed * Time.deltaTime, transform.position.z);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y - speed * Time.deltaTime, transform.position.z);
            }
        }
        else if (moveZ)
        {
            if (transform.position.z > 4f)
            {
                moveingRight = false;
            }
            else if (transform.position.z < -4f)
            {
                moveingRight = true;
            }

            if (moveingRight)
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z + speed * Time.deltaTime);
            }
            else
            {
                transform.position = new Vector3(transform.position.x, transform.position.y, transform.position.z - speed * Time.deltaTime);
            }
        } 
        

        
    }
}
