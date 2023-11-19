using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IntroductionController : MonoBehaviour
{
    public GameObject introductionImage;
    public GameObject carousel;
    public float introductionDuration = 4f;

    private float timer = 0f;
    private bool isIntroductionDone = false;

    private void Start()
    {
        introductionImage.SetActive(true);
        carousel.SetActive(false);
    }

    private void Update()
    {
        if (!isIntroductionDone)
        {
            timer += Time.deltaTime;

            if (timer >= introductionDuration)
            {
                introductionImage.SetActive(false);
                carousel.SetActive(true);
                isIntroductionDone = true;
            }
        }
    }
}
