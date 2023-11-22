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
            // Programar la activación de la misión después del tiempo de espera
            Invoke("DesactivarMision", tiempoDeEspera);
        }
    }

    void DesactivarMision()
    {
        // Aquí puedes poner la lógica para activar la misión
        // Por ejemplo, activar el panel de colisión
        panel1.SetActive(false);
        panel2.SetActive(false);
        panel3.SetActive(false);
        panel4.SetActive(true);
        indicador.SetActive(false);
        cubo2.SetActive(true);
        cuboDesactivar.SetActive(false);
    }
}
