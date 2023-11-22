using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorPausa : MonoBehaviour
{
    public GameObject pantallaPausa;
    public GameObject imagen1;
    public GameObject imagen2;
    public Button botonQuitarPausa;
    public Button botonImagen1;
    public Button botonImagen2;
    public Button botonSalir;

    void Start()
    {
        // Desactivar la pantalla de pausa al inicio
        pantallaPausa.SetActive(false);
        imagen1.SetActive(false);
        imagen2.SetActive(false);

        // Desactivar los botones al inicio
        DesactivarBotones();

 
    
    }

    void Update()
    {
        // Verificar si se presiona la tecla "Esc" para pausar/despausar el juego
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (Time.timeScale == 0f)
            {
                DespausarJuego();
            }
            else
            {
                PausarJuego();
            }
        }
        // Verificar si se presiona la tecla "a" para volver a la pantalla de pausa desde las imágenes 1 y 2
        if (Input.GetKeyDown(KeyCode.A) && (imagen1.activeSelf || imagen2.activeSelf))
        {
            PausarJuego();
            pantallaPausa.SetActive(true);
            imagen1.SetActive(false);
            imagen2.SetActive(false);
        }

    }


    public void QuitarPausa()
    {
        DespausarJuego();
    }

    public void MostrarImagen1()
    {
        imagen1.SetActive(true);
        DesactivarBotones();
    }

    public void MostrarImagen2()
    {
        imagen2.SetActive(true);
        DesactivarBotones();
    }

    public void SalirDelJuego()
    {
        Application.Quit();
    }

    void PausarJuego()
    {
        Time.timeScale = 0f; // Detener el tiempo para pausar el juego
        pantallaPausa.SetActive(true);

        // Activar los botones durante la pausa
        ActivarBotones();
    }

    void DespausarJuego()
    {
        Time.timeScale = 1f; // Restaurar el tiempo para reanudar el juego
        pantallaPausa.SetActive(false);
        imagen1.SetActive(false);
        imagen2.SetActive(false);

        // Desactivar los botones al salir de la pausa
        DesactivarBotones();
    }

    void ActivarBotones()
    {
        botonQuitarPausa.gameObject.SetActive(true);
        botonImagen1.gameObject.SetActive(true);
        botonImagen2.gameObject.SetActive(true);
        botonSalir.gameObject.SetActive(true);
    }

    void DesactivarBotones()
    {
        botonQuitarPausa.gameObject.SetActive(false);
        botonImagen1.gameObject.SetActive(false);
        botonImagen2.gameObject.SetActive(false);
        botonSalir.gameObject.SetActive(false);
    }

}



