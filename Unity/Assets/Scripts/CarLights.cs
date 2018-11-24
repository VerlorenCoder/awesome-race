using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarLights : MonoBehaviour {

    // public Renderer ligths;
    // public Material lightsON, lightsOFF;

    public Light spotLightLeft, spotLightRight;
    public bool lightsOn = true;

    void turnLightsOn()
    {
        lightsOn = true;
        spotLightLeft.intensity = 4f;
        spotLightRight.intensity = 4f;
    }

    void turnLightsOff()
    {
        lightsOn = false;
        spotLightLeft.intensity = 0;
        spotLightRight.intensity = 0;
    }

    private void Start()
    {
        if (lightsOn)
            turnLightsOff();
        else
            turnLightsOn();
    }

    // Update is called once per frame
    void Update () {
		if (Input.GetKeyDown("1"))
        {
            if (lightsOn)
                turnLightsOff();
            else
                turnLightsOn();
        }
    }
}
