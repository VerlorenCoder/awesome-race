using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraControl : MonoBehaviour {

    private float rotationY, rotationX, distance;
    private float MIN_X = -5, MAX_X = 88, MIN_DIST = -3.5f, MAX_DIST = -50;
    private Camera camera;

	// Use this for initialization
	void Start () {
        rotationX = transform.localEulerAngles.x;
        rotationY = transform.localEulerAngles.y;

        camera = gameObject.GetComponentsInChildren<Camera>()[0];

        distance = camera.transform.localPosition.z;
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.J))
        {
            rotationY += 0.2f;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rotationY -= 0.2f;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.I))
        {
            if (rotationX < MAX_X)
                rotationX += 0.2f;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.K))
        {
            if (rotationX > MIN_X)
                rotationX -= 0.2f;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.O))
        {
            var posX = camera.transform.localPosition.x;
            var posY = camera.transform.localPosition.y;

            if (distance < MIN_DIST)
                distance += 0.2f;

            camera.transform.localPosition = new Vector3(posX, posY, distance);
        }
        if (Input.GetKey(KeyCode.P))
        {
            var posX = camera.transform.localPosition.x;
            var posY = camera.transform.localPosition.y;
            if (distance > MAX_DIST)
                distance -= 0.2f;

            camera.transform.localPosition = new Vector3(posX, posY, distance);
        }
    }
}
