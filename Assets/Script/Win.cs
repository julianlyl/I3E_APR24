/*
 * Author: Julian
 * Date: 06/05/2024
 * Description: 
 * So that when the player walks through the collider a win message will appear.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Win: MonoBehaviour
{
    // This method is called when another collider enters the trigger collider attached to the object where this script is attached.
    private void OnTriggerEnter(Collider other)
    {
        // Check if the entering collider's game object has the tag "Player"
        if (other.gameObject.tag == "Player")
        {
            // Attempt to get the Player component from the entering game object
            Player player = other.gameObject.GetComponent<Player>();

            // If the Player component is found (i.e., the player variable is not null)
            if (player != null)
            {
                // Call the DisplayWinMessage method on the Player component
                player.DisplayWinMessage();
            }
        }
    }
}