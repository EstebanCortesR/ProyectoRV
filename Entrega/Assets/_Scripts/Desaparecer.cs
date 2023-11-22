using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer : MonoBehaviour
{ 
    public GameObject panel1;
    public GameObject panel2;
    public GameObject panel3;
    public GameObject panel4;
    public GameObject cuboDesactivar;
    public GameObject cubo2;
    public GameObject indicador;
    public GameObject areaActivacionMision;

    public float tiempoDeEspera = 1f; // Tiempo de espera en segundos

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && areaActivacionMision != null)
        {
            // Programar la activaci�n de la misi�n despu�s del tiempo de espera
            Invoke("DesactivarMision", tiempoDeEspera);
        }
    }

    void DesactivarMision()
    {
        // Aqu� puedes poner la l�gica para activar la misi�n
        // Por ejemplo, activar el panel de colisi�n
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        indicador.SetActive(false);
        cubo2.SetActive(true);
        cuboDesactivar.SetActive(false);
    }
}
