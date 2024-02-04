using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator ani;
    public float WalkSpeed = 2;
    public float Gravity = -9.8f;
    public float jumpForce;
    public Rigidbody RB;

    void Update()
    {
        // Get input for animations
        float walkH = Input.GetAxis("Horizontal");
        float walkV = Input.GetAxis("Vertical");

        ani.SetBool("pickup", false);

        // Activate animations
        if (walkH != 0 || walkV != 0)
        {
            ani.SetFloat("walkSpeed", WalkSpeed);
            transform.Translate(new Vector3(walkV, 0f, walkH) * WalkSpeed * Time.deltaTime);
        }
        else
        {
            ani.SetFloat("walkSpeed", 0);
        }

        if (Input.GetButtonDown("Jump"))
        {
            RB.AddForce(0, jumpForce, 0);
            ani.SetTrigger("jump");
        }

        
    }



    public void OnPickup()
    {
        ani.SetBool("pickup", true);
        Debug.Log("Pickup");
    }
}
