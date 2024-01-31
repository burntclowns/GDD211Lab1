using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLas : MonoBehaviour
{

    bool pickup = false;
    public GameObject thisGameObject;


    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");

        AnimController player = collision.gameObject.GetComponent<AnimController>();
        if (player != null)
        {
            player.OnPickup();
            Destroy(thisGameObject);
            
        }

    }
}
