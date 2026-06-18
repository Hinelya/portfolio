using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotater : MonoBehaviour
{
    Rigidbody physic;
    public int speed;
    void Start()
    {
        physic = GetComponent<Rigidbody>();
        speed = Random.Range(1,7);

        physic.angularVelocity = Random.insideUnitSphere*speed;
    }

}
