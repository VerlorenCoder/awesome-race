using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class FlatCameraControl : MonoBehaviour
{
    public GameObject Car;

    public int MinHeight = 10, MaxHeight = 200;
    public float ZoomFactor = 0.5f, CameraHeight = 25;

    void Update()
    {
        var carPosition = Car.transform.position;
        var carEulerAngles = Car.transform.eulerAngles;

        if (Input.GetKey(KeyCode.O) && CameraHeight > MinHeight)
        {
            CameraHeight -= ZoomFactor;
        }
        if (Input.GetKey(KeyCode.P) && CameraHeight < MaxHeight)
        {
            CameraHeight += ZoomFactor;
        }

        transform.position = new Vector3(carPosition.x, carPosition.y + CameraHeight, carPosition.z);
        transform.eulerAngles = new Vector3(90, carEulerAngles.y, carEulerAngles.z);
    }
}
