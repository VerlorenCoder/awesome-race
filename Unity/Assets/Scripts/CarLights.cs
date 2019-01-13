using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityStandardAssets.Vehicles.Car;

public class CarLights : MonoBehaviour {

    public CarController Car;

    // public Renderer ligths;
    // public Material brakeLightsON, brakeLightsOFF;
    public Light spotLightLeft, spotLightRight, brakeLightLeft, brakeLightRight;

    public bool lightsOn = true;
    private bool brakeLightsOn = false;

    public float brakeLightsBaseIntensity = 40f, brakeLightsIntensityMultiplier = 80f;

    void turnHeadLightsOn()
    {
        lightsOn = true;
        spotLightLeft.intensity = 2f;
        spotLightRight.intensity = 2f;
    }

    void turnHeadLightsOff()
    {
        lightsOn = false;
        spotLightLeft.intensity = 0;
        spotLightRight.intensity = 0;
    }

    void turnBrakeLightsOn(float brakeInput)
    {
        brakeLightsOn = true;
        brakeLightLeft.intensity = brakeLightsBaseIntensity + brakeLightsIntensityMultiplier * brakeInput;
        brakeLightRight.intensity = brakeLightsBaseIntensity + brakeLightsIntensityMultiplier * brakeInput;

        if (brakeInput == 0)
        {
            turnBrakeLightsOff();
            brakeLightsOn = false;
        }
    }

    void turnBrakeLightsOff()
    {
        brakeLightLeft.intensity = 0;
        brakeLightRight.intensity = 0;
    }

    private void Start()
    {
        if (lightsOn)
            turnHeadLightsOff();
        else
            turnHeadLightsOn();
    }

    void Update () {
		if (Input.GetKeyDown("1"))
        {
            if (lightsOn)
                turnHeadLightsOff();
            else
                turnHeadLightsOn();
        }
  
        if (Car.BrakeInput > 0 || brakeLightsOn)
            turnBrakeLightsOn(Car.BrakeInput);
    }
}
