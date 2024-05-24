/*
 * Author: Julian Lee Yong Le
 * Date: 19/05/2024
 * Description:
 * Contains functions related to the coin
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour
{
    /// <summary>
    /// The score value that this collectible is worth.
    /// </summary>
    public int myScore = 5;

    public Player scoreAdded;
    /// <summary>
    /// Performs actions related to collection of the collectible
    /// </summary>
    public void Collected()
    {
        // Destroy the attached GameObject
        Debug.Log("Coin collected.");
        Destroy(gameObject);
    }

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Collected();
            collision.gameObject.GetComponent<Player>().IncreaseScore(myScore);
            
        }
    }

}
