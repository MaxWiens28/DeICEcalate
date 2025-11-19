using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonTilt : MonoBehaviour
{
    public float tiltSpeed = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            gameObject.transform.Rotate(new Vector3(tiltSpeed, 0, 0) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            gameObject.transform.Rotate(new Vector3(-tiltSpeed, 0, 0) * Time.deltaTime, Space.Self);
        }
    }
}
