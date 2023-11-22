using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteraccionModelo : MonoBehaviour
{
    public GameObject imagenInteractiva;
    public Camera cam;

    void Start()
    {
        // Desactivar la imagen al inicio
        imagenInteractiva.SetActive(false);
    }

    void Update()
    {
        // Lanzar un rayo desde la cámara hacia adelante
        Ray rayo = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        // Verificar si el rayo intersecta con el modelo
        if (Physics.Raycast(rayo, out hit) && hit.collider.gameObject == gameObject)
        {
            // Verificar si se presiona la tecla "E"
            if (Input.GetKeyDown(KeyCode.E))
            {
                // Activar la imagen cuando se presiona "E"
                imagenInteractiva.SetActive(true);
            }

            // Verificar si se presiona la tecla "Q"
            if (Input.GetKeyDown(KeyCode.Q))
            {
                // Desactivar la imagen cuando se presiona "Q"
                imagenInteractiva.SetActive(false);
            }
        }
        else
        {
            // Si el rayo no intersecta con el modelo, asegurarse de que la imagen esté desactivada
            imagenInteractiva.SetActive(false);
        }
    }
}

