using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class DETECT_COLISIONS : MonoBehaviour
{
    public GameObject AGUA;

    void OnCollisionEnter(Collision otherCollider)
    {
        
        
        if (otherCollider.gameObject.CompareTag("FUEGO"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
            Instantiate(AGUA, transform.position, gameObject.transform.rotation);
        }

        if (otherCollider.gameObject.CompareTag("DRACO"))
        {
            Destroy(otherCollider.gameObject);
            Destroy(gameObject);
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
