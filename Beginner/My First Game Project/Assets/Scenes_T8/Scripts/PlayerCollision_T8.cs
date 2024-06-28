using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision_T8 : MonoBehaviour
{
    //To Stop the movement we have to stop the Player Movement Script 
    public PlayerMovement_T8 playerMovement;

    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        // Tag for the item is required to give before exectuting next line
        bool isObstacle = collision.collider.tag == "Obstacle";
        if (isObstacle)
        {
            Debug.Log("Obstacle Hit");

            playerMovement.enabled = false;

            // We can define player movement using following code as well
            // GetComponent<PlayerMovement_T8>().enabled = false;
            FindAnyObjectByType<GameManager_T8>().EndGame();
        }
    }
}
