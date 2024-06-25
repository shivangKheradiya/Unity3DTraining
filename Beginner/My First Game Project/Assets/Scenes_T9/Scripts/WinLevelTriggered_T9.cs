using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinLevelTriggered_T9 : MonoBehaviour
{
    public GameManager_T9 gameManager;

    public void OnTriggerEnter(Collider collider)
    {
        gameManager.WinLevel();
    }
}
