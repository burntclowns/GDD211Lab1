using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AnimController : MonoBehaviour
{
    [SerializeField] private Animator ani;

  
    //setting conditions and variables
    float WalkSpeed = 2;
    public float Gravity = -9.8f;
    



    void Update()
    {
        //get input for animations
        float walkH = Input.GetAxis("Horizontal");
        float walkV = Input.GetAxis("Vertical");


        //activating animations
        if (walkV != 0)
        {
            ani.SetFloat("walkSpeed", 5);
            transform.position += new Vector3(walkV * Time.deltaTime, 0f);
        }
        else
        {
            ani.SetFloat("walkSpeed", 0);
        }

        if (walkH != 0)
        {
            ani.SetFloat("walkSpeed", 5);
            transform.position += new Vector3(walkH * Time.deltaTime, 0f);
        }
        else
        {
            ani.SetFloat("walkSpeed", 0);

        }  
    }

    public void OnPickup()
    {
        bool pickup = true;
        Debug.Log("Pickup");
    }

}
