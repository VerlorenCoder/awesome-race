using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadioCar : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip clip1;
    public AudioClip clip2;
    //float vol = 1f;

    void Update()
    {
        // audioSource.volume = 1f;

        if (Input.GetKeyDown("["))
        {
            audioSource.volume -= 0.1f;
        }
        if (Input.GetKeyDown("]"))
        {
            audioSource.volume += 0.1f;
        }
        if (Input.GetKeyDown("."))
        {
            audioSource.clip = clip1;
            audioSource.Play();
        }
        if (Input.GetKeyDown("/"))
        {
            audioSource.clip = clip2;
            audioSource.Play();
        }

    }
}
