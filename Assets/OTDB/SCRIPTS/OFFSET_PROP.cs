using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OFFSET_PROP : MonoBehaviour
{
    public GameObject particlesFire;
    public GameObject[] offsetFire;
    private float timeSpawn = 1f;
    private int randomOffset;

    void Start()
    {
        InvokeRepeating("SpawnRandomTarget", timeSpawn, timeSpawn);
    }

    private void SpawnRandomTarget()
    {
        randomOffset = Random.Range(0, 25);
        Instantiate(particlesFire, offsetFire[randomOffset].transform.position,
            particlesFire.transform.rotation);

    }
    
}
