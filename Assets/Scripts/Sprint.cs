/*
 * Author: Hoo Ying Qi Praise
 * Date: 27/05/2024
 * Description: 
 * CA2 
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprint : Collectible
{
    public float increaseSpeed = 2.0f;

    public override void Collected()
    {
        Debug.Log("Speed Increased");

        var playerController = GameObject.FindWithTag("Player").GetComponent<StarterAssets.FirstPersonController>();

        if (playerController != null)
        {
            playerController.MoveSpeed += increaseSpeed;
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
