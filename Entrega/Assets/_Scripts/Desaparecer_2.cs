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
            // Programar la activación de la misión después del tiempo de espera
            Invoke("DesactivarMision", tiempoDeEspera);
        }
    }

    void DesactivarMision()
    {
        // Aquí puedes poner la lógica para activar la misión
        // Por ejemplo, activar el panel de colisión
        panel1.SetActive(false);
        cuboDesactivar.SetActive(false);

    }
}
