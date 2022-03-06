using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLANE_CONTROLLER : MonoBehaviour
{
    //VELOCIDAD LINEAL
    private float speed = 20;
    //50
    //20

    //LIMITES
    private float rightlim = -350;
    private float leftlim = 350;
    private float backlim = 350;
    private float forwardlim = -350;
    private float uplim = 300;

    //VELOCIDAD DE ROTACION
    private float turnspeed = 60;
    private float horizontalInput;
    private float verticalInput;

    //PROYECTIL
    public GameObject proyectil;
    public GameObject barril;
    public GameObject positionBarril;

    //GAMEOVER
    public bool gameOver;

    //SI COLISIONA, MUERE
    void OnCollisionEnter(Collision otherCollider)
    {
        if (otherCollider.gameObject.CompareTag("SUELO")|| otherCollider.gameObject.CompareTag("DRACO"))
        {
            gameOver = true;
            Destroy(gameObject);
            Debug.Log("PRUEBA");
            SceneManager.LoadScene("DERROTA");
        }
    }

    void Start()
    {
        transform.position = new Vector3(330, 160, 0);
        
    }

    void Update()
    {
        if (!gameOver)
        {
            //VELOCIDAD CONSTANTE HACIA ADELANTE
            transform.Translate(Vector3.forward * speed * Time.deltaTime);

            //ROTACION
            transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * horizontalInput);
            transform.Rotate(Vector3.left, turnspeed * Time.deltaTime * verticalInput);

            horizontalInput = Input.GetAxis("Horizontal");
            verticalInput = Input.GetAxis("Vertical");

            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(Vector3.forward, turnspeed * Time.deltaTime);
            }

            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(Vector3.back, turnspeed * Time.deltaTime);
            }

            //USO DE PROYECTILES
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(proyectil, transform.position, gameObject.transform.rotation);
            }

            if (Input.GetKeyDown(KeyCode.Space))
            {
                Instantiate(barril, positionBarril.transform.position, gameObject.transform.rotation);
            }

        }

        //LIMITES
        if(transform.position.z >= backlim)
        { transform.position = new Vector3(transform.position.x, transform.position.y, backlim); }
        
        if(transform.position.z <= forwardlim)
        { transform.position = new Vector3(transform.position.x, transform.position.y, forwardlim); }
        
        if(transform.position.x >= leftlim)
        { transform.position = new Vector3(leftlim, transform.position.y, transform.position.z); }
        
        if(transform.position.x <= rightlim)
        { transform.position = new Vector3(rightlim, transform.position.y, transform.position.z); }
        
        if(transform.position.y >= uplim)
        { transform.position = new Vector3(transform.position.x, uplim, transform.position.z); }
        
        

    }
}
