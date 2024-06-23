using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform playerBody;
    public float mouseSensitivity = 200f;

    float moveX;

    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        moveX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        if (moveX != 0)
        {
            playerBody.Rotate(Vector3.up * moveX);
        }
    }
}
