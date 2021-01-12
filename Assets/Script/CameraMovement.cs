using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float sensitivity = 10f;
    public float maxYAngle = 80f;
    public float speed = 10f;
    private Vector2 currentRotation;
    void Update()
    {
        currentRotation.x += Input.GetAxis("Mouse X") * sensitivity;
        currentRotation.y -= Input.GetAxis("Mouse Y") * sensitivity;
        currentRotation.x = Mathf.Repeat(currentRotation.x, 360);
        currentRotation.y = Mathf.Clamp(currentRotation.y, -maxYAngle, maxYAngle);
        Camera.main.transform.rotation = Quaternion.Euler(currentRotation.y,currentRotation.x,0);
        float h = speed * Input.GetAxis("Mouse X");
        float v = speed * Input.GetAxis("Mouse Y");
        this.transform.Rotate(-v, h, 0);
        // if (Input.GetMouseButtonDown(0))
        //     Cursor.lockState = CursorLockMode.Locked;
    }
}
