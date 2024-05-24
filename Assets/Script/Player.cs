/*
 * Author: Julian Lee Yong Le
 * Date: 19/05/2024
 * Description:
 * Contains functions related to the Player such as increasing score.
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{
    public GameObject winBox;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI winText;

    /// <summary>
    /// The current score of the player
    /// </summary>
    int currentScore = 0;

    /// <summary>
    /// Store the current door in front of the player
    /// </summary>
    Door currentDoor;

    /// <summary>
    /// Store the current collectible that the player is touching
    /// </summary>
    Collectible currentCollectible;

    /// <summary>
    /// Increases the score of the player by <paramref name="scoreToAdd"/>
    /// </summary>
    /// <param name="scoreToAdd">The amount to increase by</param>
    public void IncreaseScore(int scoreToAdd)
    {
        // Increase the score of the player by scoreToAdd
        currentScore += scoreToAdd;

        scoreText.text = "Score: " + currentScore.ToString();
    }

    public void DecreaseScore(int scoreToSubtract)
    {
        // Increase the score of the player by scoreToAdd
        currentScore -= scoreToSubtract;

        scoreText.text = "Score: " + currentScore.ToString();
    }


    public void UpdateDoor(Door newDoor)
    {
        currentDoor = newDoor;
    }

    public void UpdateCollectible(Collectible newCollectible)
    {
        currentCollectible = newCollectible;
    }


    public void DisplayWinMessage()
    {
        if (winText != null)
        {
            winText.text = "WELL DONE! You have won!!! FINALLY!";
            winText.gameObject.SetActive(true);
        }

        if (winBox != null)
        {
            winBox.gameObject.SetActive(true);
        }
    }


    void OnInteract()
    {
        // This is "null check"
        if (currentDoor != null)
        {
            currentDoor.OpenDoor();
            currentDoor = null;
        }

        // Do a null check for the currentCollectible
        if (currentCollectible != null)
        {
            IncreaseScore(currentCollectible.myScore);
            currentCollectible.Collected();
        }
    }


}
