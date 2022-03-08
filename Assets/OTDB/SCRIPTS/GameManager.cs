using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public int FUEGO_COUNT = 0;
    public int DRACO_COUNT = 0;
    private float timerCount = 5.0f;
    public GameObject canvasText;
    
    void Update()
    {
        if(FUEGO_COUNT <= 0 && DRACO_COUNT <= 0)
        {
            canvasText.SetActive(true);
            timerCount -= Time.deltaTime;
        }

        if (timerCount <= 0f)
        {
            SceneManager.LoadScene("MENU");
        }
    }
    void Start()
    {
        DRACO_COUNT = GameObject.FindGameObjectsWithTag("DRACO").Length;
        FUEGO_COUNT = GameObject.FindGameObjectsWithTag("FUEGO").Length;
    }
}
