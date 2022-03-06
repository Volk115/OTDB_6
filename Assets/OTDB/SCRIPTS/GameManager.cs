using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class COUNT_MANAGER : MonoBehaviour
{
    public int FUEGO_COUNT = 0;
    public int DRACO_COUNT = 0;
    
    void Update()
    {
        if(FUEGO_COUNT >= 8 && DRACO_COUNT >= 4)
        {
            SceneManager.LoadScene("DERROTA");
        }
    }
}
