using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float runSpeed = 500f;
    public float strafeSpeed = 500f;
    public float jumpForce = 15f;

    protected bool strafeLeft = false;
    protected bool strafeRight = false;
    protected bool doJump = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("a"))
        {
            strafeLeft = true;
        } else
        {
            strafeLeft = false;
        }

        if(Input.GetKey("d"))
        {
            strafeRight = true;
        } else
        {
            strafeRight = false;
        }

        if(Input.GetKeyDown("space"))
        {
            doJump = true;
        }

        if(transform.position.y < -5f)
        {
            Debug.Log("The End!");
        }
    }

    void FixedUpdate()
    {
        rb.AddForce(0, 0, runSpeed * Time.deltaTime);

        if(strafeLeft)
        {
            rb.AddForce(-strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(strafeRight)
        {
            rb.AddForce(strafeSpeed * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if(doJump)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            doJump = false;
        }
    }
}
