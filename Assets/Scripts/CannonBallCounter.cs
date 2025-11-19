using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class CannonBallCounter : MonoBehaviour
{
    public CannonFire cannonBalls;
    public TMP_Text cannonBallCountText;

    void Update()
    {
        cannonBallCountText.text = cannonBalls.cannonBalls.ToString();
    }
}
