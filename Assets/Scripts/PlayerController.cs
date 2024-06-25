using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    [SerializeField] Animator animator;
    float movX, movZ, camX;
    public float mouseSensitivity = 100f;
    Vector3 move;

    void Start()
    {
        animator = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        camX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;

        if (camX != 0)
        {
            transform.Rotate(Vector3.up * camX);
        }
    }

    private void FixedUpdate()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");


        if (movX != 0 || movZ != 0)
        {
            transform.Translate(movX * Time.deltaTime * speed, 0, movZ * Time.deltaTime * speed);

            animator.SetFloat("VelX", movX);
            animator.SetFloat("VelY", movZ);
        }
    }
}