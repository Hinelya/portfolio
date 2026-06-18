using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour
{
    Rigidbody physics;
    [SerializeField] float speed;
    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody>();
        physics.velocity = transform.forward * speed;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
