using UnityEngine;
using System.Collections.Generic;

public class SpawnEnemigos : MonoBehaviour
{

    public List<GameObject> enemigos; // lista de enemigos

    public List<Transform> camino1;
    public List<Transform> camino2;
    public List<Transform> camino3;

    public Transform puntoSpawn;

    void Start()
    {
        InvokeRepeating("CrearEnemigo", 1f, 3f);
    }

    void CrearEnemigo()
    {
        // elegir enemigo random
        int enemigoRandom = Random.Range(0, enemigos.Count);

        GameObject enemigo = Instantiate(enemigos[enemigoRandom], puntoSpawn.position, Quaternion.identity);

        // elegir camino random
        int caminoRandom = Random.Range(1, 4);

        mobimentenemi script = enemigo.GetComponent<mobimentenemi>();

        if (caminoRandom == 1)
        {
            script.puntosDeRuta = camino1;
        }
        else if (caminoRandom == 2)
        {
            script.puntosDeRuta = camino2;
        }
        else
        {
            script.puntosDeRuta = camino3;

        }
    }
}