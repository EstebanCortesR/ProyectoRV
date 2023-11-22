using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Colision : MonoBehaviour
{
    //public GameObject panel_1;
    public GameObject mision_2;
    void Start()
    {
        // Desactivar el panel de colisión al inicio
        mision_2.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("cubo_1"))
        {
            // Mostrar el panel de colisión al colisionar con el cubo_1
            mision_2.SetActive(true);
        }
    }
}
