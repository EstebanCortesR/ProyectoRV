using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Carusel : MonoBehaviour
{
    public GameObject[] images;
    public GameObject introductionImage;
    private int currentIndex = 0;
    private bool introShown = false;
    private bool carouselActive = true; // Variable para controlar la visibilidad del carrusel

    private void Start()
    {
        ShowIntroduction();
    }

    private void Update()
    {
        if (introShown && carouselActive)
        {
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                ShowImage(currentIndex + 1);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                ShowImage(currentIndex - 1);
            }

            // Comprueba si se ha presionado la tecla "A" para desactivar el carrusel
            if (Input.GetKeyDown(KeyCode.A))
            {
                HideCarousel();
            }
        }
    }

    private void ShowIntroduction()
    {
        introductionImage.SetActive(true);
        introShown = true;

        Invoke("HideIntroduction", 4f);
    }

    private void HideIntroduction()
    {
        introductionImage.SetActive(false);
        ShowImage(currentIndex);
    }

    private void ShowImage(int index)
    {
        index = Mathf.Clamp(index, 0, images.Length - 1);

        for (int i = 0; i < images.Length; i++)
        {
            images[i].SetActive(i == index);
        }

        currentIndex = index;
    }

    private void HideCarousel()
    {
        foreach (var image in images)
        {
            image.SetActive(false);
        }
        carouselActive = false;
    }
}


