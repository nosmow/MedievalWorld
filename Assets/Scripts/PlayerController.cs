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
        //playerController = GetComponent<CharacterController>();
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        transform.Rotate(0, movX * Time.deltaTime * degreeMultiplier, 0);
        transform.Translate(0, 0, movZ * Time.deltaTime * speed);

        animator.SetFloat("VelX", movX);
        animator.SetFloat("VelZ", movZ);

        /*AnimLogic();

        movX = Input.GetAxis("Horizontal");
        movZ = Input.GetAxis("Vertical");

        move = transform.right * movX + transform.forward * movZ;

        if (movX != 0 || movZ != 0)
        {
            transform.Rotate(0, movX * degreeMultiplier, 0);
            playerController.Move(move * speed * Time.deltaTime);
        }*/
    }

    void AnimLogic()
    {
       // animator.SetFloat("X", new mov.)
    }
}
