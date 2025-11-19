using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public Transform cannonBallSpawnPoint;
    public GameObject cannonBallPrefab;
    public float cannonBallSpeed = 50f;
    public float cannonBalls = 5f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cannonBalls > 0)
        {
            var cannonBall = Instantiate(cannonBallPrefab, cannonBallSpawnPoint.position, cannonBallSpawnPoint.rotation);
            cannonBall.GetComponent<Rigidbody>().velocity = cannonBallSpawnPoint.forward * cannonBallSpeed;
            cannonBalls -= 1f;
        }
    }
}
