/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    /// <summary>
    /// Stores the current player that can interact with the object
    /// </summary>
    protected Player currentPlayer;

    /// <summary>
    /// Update the player's Interactable
    /// </summary>
    /// <param name="thePlayer">The player to update</param>
    public void UpdatePlayerInteractable(Player thePlayer)
    {
        thePlayer.UpdateInteractable(this);
    }

    /// <summary>
    /// Remove the player's Interactable
    /// </summary>
    /// <param name="thePlayer">The player that should remove its Interactable</param>
    public void RemovePlayerInteractable(Player thePlayer)
    {
        thePlayer.RemoveInteractable();
    }

    /// <summary>
    /// Execute the object's interaction
    /// </summary>
    /// <param name="thePlayer">The player that interacted with the object</param>
    /// The virtual will allow the child to overide it
    public virtual void Interact(Player thePlayer)
    {
        Debug.Log(gameObject.name + " was interacted with.");
    }
}
