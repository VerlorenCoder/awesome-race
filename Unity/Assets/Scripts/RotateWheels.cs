using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class RotateWheels : MonoBehaviour
{

    public CarController CarController;
    public float RotationFactor = 0.3f;

    // Update is called once per frame
    void Update()
    {
        var current_speed = CarController.CurrentSpeed;

        transform.Rotate(Vector3.right * current_speed * RotationFactor);
    }
}
