using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonRotation : MonoBehaviour
{
    public float rotateSpeed = 100f;

    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            gameObject.transform.Rotate(new Vector3(0, 0, -rotateSpeed) * Time.deltaTime, Space.Self);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            gameObject.transform.Rotate(new Vector3(0, 0, rotateSpeed) * Time.deltaTime, Space.Self);
        }
    }
}
