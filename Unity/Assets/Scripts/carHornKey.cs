using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carHornKey : MonoBehaviour
{

    public AudioSource carHorn;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H) || Input.GetButton("Fire2")) {
            {
                carHorn.Play();
            }
        }
    }
}
