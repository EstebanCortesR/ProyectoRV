using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desaparecer_2 : MonoBehaviour
{
    public GameObject panel1;
    public GameObject cuboDesactivar;
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
        cuboDesactivar.SetActive(false);

    }
}
