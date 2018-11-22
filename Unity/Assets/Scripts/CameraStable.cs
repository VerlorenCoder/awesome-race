using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStable : MonoBehaviour {

    public GameObject Car;
    public float CarX, CarY, CarZ;

	void Start () {
	}
	
	void Update () {
        CarX = Car.transform.eulerAngles.x;
        CarY = Car.transform.eulerAngles.y;
        CarZ = Car.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);

        // Car.transform.
	}
}
