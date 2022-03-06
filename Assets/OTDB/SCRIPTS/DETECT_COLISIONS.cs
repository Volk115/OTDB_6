using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DETECT_COLISIONS : MonoBehaviour
{
    public GameObject AGUA;

    //public GameManager GameManagerScript;


    void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("FUEGO"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
            Instantiate(AGUA, transform.position, gameObject.transform.rotation);
            //GameManagerScript.FUEGO_COUNT = +1;
        }

        if (otherCollider.gameObject.CompareTag("DRACO"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
            //GameManagerScript.DRACO_COUNT = +1;
        }

        if (otherCollider.gameObject.CompareTag("SUELO"))
        {
            //Destroy(otherCollider.gameObject);
            Destroy(gameObject);
            Instantiate(AGUA, transform.position, gameObject.transform.rotation);
        }


        Destroy(gameObject);
    
    }

    void Start()
    {
        Destroy(gameObject, 5);

    }
}
