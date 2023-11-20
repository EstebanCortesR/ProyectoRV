using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopVideos : MonoBehaviour
{
    public GameObject stopVideo;
    public GameObject aparecePantalla;
    bool coliciona = false;

    void Start()
    {

    }

    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            stopVideo.SetActive(false);
            aparecePantalla.SetActive(true);
            coliciona = true;
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            coliciona = false;
        }
    }
}
