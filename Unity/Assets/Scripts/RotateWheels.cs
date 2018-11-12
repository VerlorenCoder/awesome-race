using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RotateWheels : MonoBehaviour {
    public GameObject Car, Wheels;
    public CarController CarController;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var max_speed = CarController.MaxSpeed;
        var current_speed = CarController.CurrentSpeed;
        var size = 1;
        var size_addition = current_speed / max_speed;
        var angle = CarController.CurrentSteerAngle;

        transform.localScale = new Vector3(size + size_addition, transform.localScale.y, transform.localScale.z);
        // transform.localRotation = new Vector3(transform.localRotation.x, transform.localRotation.y, transform.localRotation.z);
        // transform.localPosition = new Vector3(size + size_addition, transform.localPosition.y, transform.localPosition.z);
	}
}
