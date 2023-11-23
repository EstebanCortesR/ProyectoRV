using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproductorVideos : MonoBehaviour
{
    public GameObject apareDes;
    public GameObject pantallaSola;
    public GameObject video;
    bool oprimeE = false;
    bool coliciona = false;

    void Start()
    {
        apareDes.SetActive(false);
        video.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && coliciona == true)
        {
            pantallaSola.SetActive(false);
            video.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            apareDes.SetActive(true);
            coliciona = true;
        }

    }

    private void reproducirVideo()
    {

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            apareDes.SetActive(false);
            coliciona = false;
            oprimeE = false;
        }
    }
}
