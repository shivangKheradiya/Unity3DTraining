using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision_T6 : MonoBehaviour
{
    //To Stop the movement we have to stop the Player Movement Script 
    public PlayerMovement_T6 playerMovement;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        // Tag for the item is required to give before exectuting next line
        bool isObstacle = collision.collider.tag == "Obstacle";
        if (isObstacle)
        {
            Debug.Log("Obstacle Hit");
            playerMovement.enabled = false;
        }
    }
}
