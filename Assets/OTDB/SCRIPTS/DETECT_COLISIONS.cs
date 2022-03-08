using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DETECT_COLISIONS : MonoBehaviour
{
    public GameObject AGUA;

    public GameManager GameManagerScript;

    public ParticleSystem explosionParticleSystem;

    void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("FUEGO"))
        {
            if (!gameObject.CompareTag("PLAYER"))
            {
                Instantiate(AGUA, transform.position, gameObject.transform.rotation);
            }

            Destroy(otherCollider.gameObject);
            GameManagerScript.FUEGO_COUNT -= 1;
        }

        if (otherCollider.gameObject.CompareTag("DRACO"))
        {
            Instantiate(explosionParticleSystem, otherCollider.transform.position, gameObject.transform.rotation);
            Destroy(otherCollider.gameObject);
            GameManagerScript.DRACO_COUNT -= 1;
        }

        if (otherCollider.gameObject.CompareTag("SUELO"))
        {
            if (!gameObject.CompareTag("PLAYER"))
            {
                Instantiate(AGUA, transform.position, gameObject.transform.rotation);
            }
            
        }
       
        Destroy(gameObject);
    }

    void Start()
    {
        GameManagerScript = FindObjectOfType<GameManager>();

        if (!gameObject.CompareTag("PLAYER"))
        {
            Destroy(gameObject, 5);
        }
    }
}
