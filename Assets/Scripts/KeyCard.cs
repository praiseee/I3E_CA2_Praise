/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyCard : MonoBehaviour
{
    /// <summary>
    /// The door that this key card unlocks
    /// </summary>
    public Door linkedDoor;

    Material[] matArray = new Material[] { /* your materials here */ };

    private void Start()
    {
        // Check if there is a linked door
        if(linkedDoor != null)
        {
            // Lock the door that is linked
            linkedDoor.SetLock(true);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Check if it's the Player colliding with the keycard
        if(collision.gameObject.tag == "Player")
        {
            // Tell the door to unlock itself.
            linkedDoor.SetLock(false);
            Destroy(gameObject);
        }
    }

}
