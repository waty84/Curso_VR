using System.IO;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MiPrimerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
   [SerializeField] private int vidas = 5;

    void Start()
    {
        Debug.Log("Hola world");
        string nombreJugador;
        int edadJugador = 18;
        nombreJugador = "Waty";
        Debug.Log(nombreJugador);
        Debug.Log(edadJugador);
        nombreJugador = "Edu";
        Debug.Log(nombreJugador);
        Debug.Log(vidas);
        calcularVelocidad(500f, 10f);
    }
    void calcularVelocidad(float distancia, float tiempo)
    {
        float velocidad = distancia / tiempo;
        Debug.Log("La velocidad es: "+ velocidad);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
