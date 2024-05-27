/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : Interactable
{
    /// Flags if the door is open
    bool opened = false;

    /// Flags if the door is locked
    bool locked = false;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the obejct entering the trigger has the "Player" tag
        if(currentPlayer.tag == "Player")
        {
            currentPlayer = other.gameObject.GetComponent<Player>(); // Store the current player
            UpdatePlayerInteractable(currentPlayer); // Update the player interactable to be this door.
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Check if the obejct exiting the trigger has the "Player" tag
        if (currentPlayer.tag == "Player")
        {
            RemovePlayerInteractable(currentPlayer); // Remove the player Interactable
            currentPlayer = null; // Set the current Player to null
        }
    }

    /// Handles the door's interaction
    /// <param name="thePlayer">The player that interacted with the door</param>
    public override void Interact(Player thePlayer)
    {
        // Call the Interact function from the base Interactable class.
        base.Interact(thePlayer);
        OpenDoor(); // Call the OpenDoor() function
    }

    /// Handles the door opening 
    public void OpenDoor()
    {
        // Door should open only when it is not locked
        if(!locked && !opened)
        {
            // Create a new Vector3 and store the current rotation.
            Vector3 newRotation = transform.eulerAngles;
            newRotation.y += 90f;
            transform.eulerAngles = newRotation;
            opened = true; // Set the opened bool to true
        }
    }

    /// Sets the lock status of the door.
    /// <param name="lockStatus">The lock status of the door</param>
    public void SetLock(bool lockStatus)
    {
        locked = lockStatus; // Assign the lockStatus value to the locked bool.
    }
}
