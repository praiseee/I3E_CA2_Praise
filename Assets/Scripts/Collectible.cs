/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : Interactable //the child 
{
    /// <summary>
    /// The score value that this collectible is worth.
    /// </summary>
    public int myScore = 5;

    /// <summary>
    /// Performs actions related to collection of the collectible
    /// </summary>
    public void Collected()
    {
        // Destroy the attached GameObject
        Destroy(gameObject);
    }

    /// <summary>
    /// Handles the collectibles interaction.
    /// Increase the player's score and destroy itself
    /// </summary>
    /// <param name="thePlayer">The player that interacted with the object.</param>
    public override void Interact(Player thePlayer)
    {
        base.Interact(thePlayer);
        thePlayer.IncreaseScore(myScore);
        Collected();
    }

    /// Callback function for when a collision occursq
    /// <param name="collision">Collision event data</param>
    private void OnCollisionEnter(Collision collision)
    {
        // Check if the object that
        // touched me has a 'Player' tag
        if(collision.gameObject.tag == "Player")
        {
            currentPlayer = collision.gameObject.GetComponent<Player>();
            UpdatePlayerInteractable(currentPlayer); //from Interactible class line 22
            Debug.Log("Collectible Collected");
        }
    }

}
