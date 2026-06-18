using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour
{
    public GameObject explosion;
    public GameObject shipExplosion;
    private GameController gameController;

    private void Start()
    {
        gameController = GameObject.FindWithTag("GameController").GetComponent<GameController>();
    }
    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Boundary")
        {
            return;
        }

        Instantiate(explosion, transform.position, transform.rotation);

        if(other.tag == "Player")
        {
            Instantiate(shipExplosion, other.transform.position, other.transform.rotation);
            gameController.GameOver();
        }
        else if(other.tag == "Bolt")
        {
            gameController.UpdateScore();
        }
        
        Destroy(other.gameObject);
        Destroy(gameObject);

    }
}
