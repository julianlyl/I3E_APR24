/*
 * Author: Julian
 * Date: 06/05/2024
 * Description: 
 * The door that opens when the player is near it 
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door2 : MonoBehaviour
{
    bool opened = false;
    private void OnTriggerEnter(Collider other)
    {

        // Check whether only Player enter and whether door is NOT opened
        if (other.gameObject.tag == "Player" && !opened)
        {
            OpenDoor();
        }
    }


    ///<summary>
    /// Handles open door function
    ///</summary>
    void OpenDoor()
    {
        // Vector3 is x y z
        // Create new Vector3 and store current rotation of door
        // Must store in new Vector than can change rotation

        Vector3 newRotation = transform.eulerAngles;

        // Add 90 degrees to y axis rotation

        newRotation.y += 90f;

        //Assign the new rotation to transform

        transform.eulerAngles = newRotation;

        opened = true;
    }

}