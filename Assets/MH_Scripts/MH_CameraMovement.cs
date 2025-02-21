using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MH_CameraMovement : MonoBehaviour
{
    public float mouseSensitivity = 2f;
    public Transform playerBody;
    
    private float verticalRotation = 0f;
    private float horizontalRotation = 0f;

    void Start()
    {
        // Lock and hide the cursor
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    void Update()
    {
        // Get mouse input
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity;

        // Rotate vertically (camera only)
        verticalRotation -= mouseY;
        verticalRotation = Mathf.Clamp(verticalRotation, -90f, 90f);
        transform.localRotation = Quaternion.Euler(verticalRotation, 0f, 0f);

        // Rotate horizontally (entire player)
        horizontalRotation += mouseX;
        playerBody.rotation = Quaternion.Euler(0f, horizontalRotation, 0f);
    }
}
