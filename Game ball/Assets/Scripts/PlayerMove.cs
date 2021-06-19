using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 cameraOffset;
    public float speed = 50f;

    private Rigidbody rb;
    private Vector3 controlDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        cameraTransform.position = transform.position + cameraOffset;
        controlDirection = cameraTransform.TransformDirection(new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical")));
    }

    void FixedUpdate()
    {
        rb.AddForce(controlDirection * speed * Time.deltaTime, ForceMode.VelocityChange);

        if(Input.GetKeyDown("space"))
        {
            rb.AddForce(0, 0, 0, ForceMode.VelocityChange);
        }
    }
}