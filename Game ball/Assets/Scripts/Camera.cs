using UnityEngine;

public class Camera : MonoBehaviour
{
    public Transform cameraTransform;
    public Vector3 cameraOffset;

    void Update()
    {
        cameraTransform.position = transform.position + cameraOffset;
    }
}
