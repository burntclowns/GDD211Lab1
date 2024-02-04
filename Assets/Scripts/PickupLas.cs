using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupLas : MonoBehaviour
{

    
    public GameObject thisGameObject;


    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("collided");

        AnimController player = other.gameObject.GetComponent<AnimController>();
        

        if (player != null)
        {
            player.OnPickup();
            Destroy(thisGameObject);
            //text.
            
            
        }

    }

}
