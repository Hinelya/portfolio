using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallControl : MonoBehaviour
{
    public Rigidbody physics;
    public int speed;
    public int counter;

    public Text pointText;
    public Text gameOverText;

    // Start is called before the first frame update
    void Start()
    {
        physics = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float yatay = Input.GetAxis("Horizontal");
        float dikey = Input.GetAxis("Vertical");

        Vector3 vektor = new Vector3(yatay, 0, dikey);

        physics.AddForce(vektor*speed);

    }
    
    void OnTriggerEnter(Collider other) {
        other.gameObject.SetActive(false);
        counter++;
        pointText.text = "Points: " + counter;

        if(counter == 11) {
            gameOverText.gameObject.SetActive(true);
        }
    }

}
