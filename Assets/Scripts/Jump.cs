/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : Collectible
{
    public float IncreaseJump = 100.5f; 

    public override void Collected()
    {
        Debug.Log("Jump Height Increased");
        var player = GameObject.FindWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();

        if (player == null)
        {
            player.JumpHeight += IncreaseJump;
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
