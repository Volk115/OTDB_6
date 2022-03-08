using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE_OBJECT : MonoBehaviour
{
    //VELOCIDAD DE ROTACION
    private float rotateSpeed = 1200;

    //SE LLAMA AL SCRIPT PLAYER CONTROLLER
    public PLANE_CONTROLLER playerControllerScript;

    void Start()
    {
        playerControllerScript = FindObjectOfType<PLANE_CONTROLLER>();
    }

    void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Rotate(Vector3.right * Time.deltaTime * rotateSpeed);
        }
    }
}
