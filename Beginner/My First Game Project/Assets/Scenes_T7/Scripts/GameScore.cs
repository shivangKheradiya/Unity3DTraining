using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameScore_T7 : MonoBehaviour
{
    public Transform PlayerPosition;
    public TextMeshProUGUI ScoreText;

    // Update is called once per frame
    private void Update()
    {
        ScoreText.text = Math.Round(PlayerPosition.transform.position.z, 1).ToString();
    }
}
