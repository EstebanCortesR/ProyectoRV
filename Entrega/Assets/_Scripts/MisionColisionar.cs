using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MisionColisionar : MonoBehaviour
{
    
    public GameObject panel1;
    public GameObject panel2;
    public GameObject cubo2;
    public GameObject areaActivacionMision;

    public float tiempoDeEspera = 1f; // Tiempo de espera en segundos

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && areaActivacionMision != null)
        {
            // Programar la activaci�n de la misi�n despu�s del tiempo de espera
            Invoke("ActivarMision", tiempoDeEspera);
        }
    }

    void ActivarMision()
    {
        // Aqu� puedes poner la l�gica para activar la misi�n
        // Por ejemplo, activar el panel de colisi�n
        panel2.SetActive(true);
        cubo2.SetActive(true);
    }
}


