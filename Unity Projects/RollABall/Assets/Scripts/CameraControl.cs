using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public GameObject Ball;
    public Vector3 distance;

    // Start is called before the first frame update
    void Start()
    {
        distance = transform.position - Ball.transform.position;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        transform.position = Ball.transform.position + distance;
    }
}
