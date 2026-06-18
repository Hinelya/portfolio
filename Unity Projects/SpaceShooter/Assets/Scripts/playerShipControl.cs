using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary 
{
    public float xMin, xMax, zMin, zMax;
}

public class playerShipControl : MonoBehaviour
{
    Rigidbody physics;
    [SerializeField] int speed;
    [SerializeField] int flip;
    [SerializeField] float nextFire;
    [SerializeField] float fireRate;
    public Boundary boundary;
    public GameObject shot;
    public GameObject shotSpawn;


    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && Time.time > nextFire)
        {
            nextFire = Time.time + fireRate;
            Instantiate(shot, shotSpawn.transform.position, shotSpawn.transform.rotation);
        }
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0, moveVertical);

        physics.velocity = movement * speed;
        Vector3 position = new Vector3(Mathf.Clamp(physics.position.x, boundary.xMin, boundary.xMax),0,Mathf.Clamp(physics.position.z, boundary.zMin, boundary.zMax));
        
        physics.position = position;
        physics.rotation = Quaternion.Euler(0,0,physics.velocity.x * -1 * flip);
    }
}
