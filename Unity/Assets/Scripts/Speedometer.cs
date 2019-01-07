using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Vehicles.Car;

public class Speedometer : MonoBehaviour {

    private CarController Car;
    public Text SpeedText;

    private void Awake()
    {
        SpeedText.alignment = TextAnchor.MiddleRight;
        Car = GetComponent<CarController>();
    }

    void Start () {
        DisplayCurrentSpeed();
    }

    void Update () {
        DisplayCurrentSpeed();
	}

    void DisplayCurrentSpeed()
    {
        var speed = (int) Mathf.Ceil(Car.CurrentSpeed);
        var text = speed + " km/h";
        SpeedText.text = text;
    }
}
