using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevelTriggered_T10 : MonoBehaviour
{
    public GameManager_T10 gameManager;

    public void OnTriggerEnter(Collider collider)
    {
        gameManager.WinLevel();
    }
}
