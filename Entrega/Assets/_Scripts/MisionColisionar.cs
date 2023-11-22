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
            // Programar la activación de la misión después del tiempo de espera
            Invoke("ActivarMision", tiempoDeEspera);
        }
    }

    void ActivarMision()
    {
        // Aquí puedes poner la lógica para activar la misión
        // Por ejemplo, activar el panel de colisión
        panel2.SetActive(true);
        cubo2.SetActive(true);
    }
}


