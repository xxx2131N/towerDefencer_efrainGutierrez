using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class mobimentenemi : MonoBehaviour
{
    public List<Transform> puntosDeRuta;
    private Transform puntoActual;
    private int indice = 0;

    private float velocidad = 1f;

    void Start()
    {
        puntoActual = puntosDeRuta[0];
    }

    void Update()
    {
        transform.Translate((puntoActual.position - transform.position).normalized * Time.deltaTime * velocidad, Space.World);

        if (Vector3.Distance(transform.position, puntoActual.position) < 0.1f)
        {
            if (indice < puntosDeRuta.Count - 1)
            {
                indice++;
                puntoActual = puntosDeRuta[indice];
            }
            else
            {
                Destroy(gameObject);
            }
        }
    }
}