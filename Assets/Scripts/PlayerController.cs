using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float degreeMultiplier = 200f;
    [SerializeField] Animator animator;
    float movX, movZ;
    Vector3 move;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        if (movX != 0 || movZ != 0)
        {
            transform.Rotate(0, movX * Time.deltaTime * degreeMultiplier, 0);
            transform.Translate(0, 0, movZ * Time.deltaTime * speed);

            animator.SetFloat("VelX", movX);
            animator.SetFloat("VelY", movZ);
        }
    }
}
