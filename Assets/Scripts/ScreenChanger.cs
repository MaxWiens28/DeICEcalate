using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

public class ScreenChanger : MonoBehaviour
{
    bool levelCompleted;
    bool levelFailed;
    public GameObject[] blocks;
    public GameObject[] iceBlocks;
    public GameObject levelCompleteScreen;
    public GameObject levelFailedScreen;
    public GameObject pausedScreen;
    public CannonFire cannonBalls;

    void Update()
    {
        iceBlocks = GameObject.FindGameObjectsWithTag("IceBlock");

        if (CheckIceblocksYPosition())
        {
            levelCompleteScreen.SetActive(true);
            Destroy(levelFailedScreen);
            Destroy(pausedScreen);
        }

        if (cannonBalls.cannonBalls == 0)
        {
            StartCoroutine(TimeDelay());
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pausedScreen.activeSelf == false)
            {
                pausedScreen.SetActive(true);
            }
            else
            {
                pausedScreen.SetActive(false);
            }
        }
    }

    bool CheckIceblocksYPosition()
    {
        if(iceBlocks.All(iceBlock => iceBlock.transform.position.y <= -1))
        {
            return true;
        }
        return false;
    }

    IEnumerator TimeDelay()
    {
        yield return new WaitForSeconds(5);
        levelFailedScreen.SetActive(true);
        Destroy(pausedScreen);
    }
}