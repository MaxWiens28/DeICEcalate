using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float life = 3;
    public GameObject Cannonball;
    public ParticleSystem Explosion;

    void Awake()
    {
        Destroy(Cannonball, life);
    }

    void OnCollisionEnter(Collision collision)
    {
        Destroy(Cannonball);
        Instantiate(Explosion, transform.position, Quaternion.identity);
    }
}
