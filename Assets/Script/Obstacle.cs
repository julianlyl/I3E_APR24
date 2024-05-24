/*
 * Author: Julian
 * Date: 06/05/2024
 * Description: 
 * The obstacles that will cause player to lose 5 points
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int penaltyScore = 5;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Player>().DecreaseScore(penaltyScore);
        }
    }
}
