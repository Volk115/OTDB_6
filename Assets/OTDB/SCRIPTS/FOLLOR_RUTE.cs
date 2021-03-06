using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOLLOR_RUTE : MonoBehaviour
{
    public Transform[] PuntosDeRuta;
    public int TotalPoints;
    public int DestinoActual;
    public float Speed = 30;

    void Start()
    {
        transform.position = PuntosDeRuta[0].position;
        TotalPoints = PuntosDeRuta.Length;
        DestinoActual = 1;
        transform.LookAt(PuntosDeRuta[DestinoActual].position);
    }

    void Update()
    {
        if (Vector3.Distance(transform.position, PuntosDeRuta[DestinoActual].position)< 0.1f)
        {
            DestinoActual++;
            if (DestinoActual == TotalPoints)
            {
                DestinoActual = 0;
            }
            transform.LookAt(PuntosDeRuta[DestinoActual].position);
        }
        transform.position = Vector3.MoveTowards(transform.position, PuntosDeRuta[DestinoActual].position, Speed * Time.deltaTime);

        
    }
}
