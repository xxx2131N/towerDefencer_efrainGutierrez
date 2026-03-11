using UnityEngine;

public class Enemigo : MonoBehaviour
{

    public int vida; // vida del enemigo
    public int dañoAlImpactarBase; // daño que inflige al impactar con la base
    public int dañoAlDispararTorretas; // daño que Hace al disparar a las torretas
    public int dañoAlDispararMuros; // daño que hace al disparar a los muros
    public int puntuacionAlSerDestruido; // puntuación que otorga al ser destruido
    public float velocidad; // velocidad de movimiento del enemigo
    private int rangoDeDeteccion =1; // rango de detección para atacar la base, torretas o muros



    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void DetectarColisionConBase()
    {
        // Lógica para detectar colisión con la base y aplicar daño
    }

    private void DetectarTorretas()
    {
        // Lógica para detectar colisión con torretas y aplicar daño
    }

    private void DetectarMuros()
    {
        // Lógica para detectar colisión con muros y aplicar daño
    }

}
