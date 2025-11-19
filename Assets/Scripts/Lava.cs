using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lava : MonoBehaviour
{
    Rigidbody rigidbody;

    public float underLavaDrag = 3f;

    public float underLavaAngularDrag = 1f;

    public float airDrag = 0f;

    public float airAngularDrag = 0.05f;

    public float floatingPower = 4f;

    public float lavaHeight = 1f;

    bool underlava;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float difference = transform.position.y - lavaHeight;

        if(difference < 0)
        {
            rigidbody.AddForceAtPosition(Vector3.up * floatingPower * Mathf.Abs(difference), transform.position, ForceMode.Force);
            if (!underlava)
            {
                underlava = true;
                SwitchState(true);
            }
        }
        else if (underlava)
        {
            underlava = false;
            SwitchState(false);
        }
    }

    void SwitchState(bool isUnderLava)
    {
        if (isUnderLava)
        {
            rigidbody.drag = underLavaDrag;
            rigidbody.angularDrag = underLavaAngularDrag;
        }
        else
        {
            rigidbody.drag = airDrag;
            rigidbody.angularDrag = airAngularDrag;
        }
    }
}
