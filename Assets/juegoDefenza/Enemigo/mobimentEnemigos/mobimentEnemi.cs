using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class mobimentenemi : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Transform Camino1;
    public List<Transform> puntosDeRuta1;
    public Transform Camino2;
    public List<Transform> puntosDeRuta2;
    public Transform Camino3;
    public List<Transform> puntosDeRuta3;
    private int vida;
    private int daño;
    private float velocidad;
     
     
    void Start()
    {
        velocidad=1f; // Puedes ajustar la velocidad según tus necesidades
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((Camino1.position-transform.position).normalized 
        *Time.deltaTime*velocidad,Space.World);

        if (Vector3.Distance(transform.position,Camino1.position)<0.1f)
        {
            if (puntosDeRuta1.Count> puntosDeRuta1.IndexOf(Camino1)+1)
            {
                Camino1=puntosDeRuta1[puntosDeRuta1.IndexOf(Camino1)+1];
            }
            else
            {
                // Lógica para cuando el enemigo llega al final del camino
                // Por ejemplo, puedes destruir el enemigo o restar vida al jugador
                Destroy(gameObject);
            }
        }
        
        transform.Translate((Camino2.position-transform.position).normalized 
        *Time.deltaTime*velocidad,Space.World);

        if (Vector3.Distance(transform.position,Camino2.position)<0.1f)
        {
            if (puntosDeRuta2.Count> puntosDeRuta2.IndexOf(Camino2)+1)
            {
                Camino2=puntosDeRuta2[puntosDeRuta2.IndexOf(Camino2)+1];
            }
            else
            {
                // Lógica para cuando el enemigo llega al final del camino
                // Por ejemplo, puedes destruir el enemigo o restar vida al jugador
                Destroy(gameObject);
            }
        }

        transform.Translate((Camino3.position-transform.position).normalized 
        *Time.deltaTime*velocidad,Space.World);

        if (Vector3.Distance(transform.position,Camino3.position)<0.1f)
        {
            if (puntosDeRuta3.Count> puntosDeRuta3.IndexOf(Camino3)+1)
            {
                Camino3=puntosDeRuta3[puntosDeRuta3.IndexOf(Camino3)+1];
            }
            else
            {
                // Lógica para cuando el enemigo llega al final del camino
                // Por ejemplo, puedes destruir el enemigo o restar vida al jugador
                Destroy(gameObject);
            }
        }

    }

}
