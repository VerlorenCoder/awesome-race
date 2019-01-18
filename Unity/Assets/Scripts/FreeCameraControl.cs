using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraControl : MonoBehaviour {

    public float rotationXFactor = 0.7f, rotationYFactor = 2, distanceFactor = 0.2f;

    private float rotationY, rotationX, distance;
    private readonly float MIN_X = -5, MAX_X = 86, MIN_DIST = -3.5f, MAX_DIST = -20;
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
        // Y-rotation manipulation
        if (Input.GetKey(KeyCode.J))
        {
            rotationY += rotationYFactor;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rotationY -= rotationYFactor;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }

        // X-rotation manipulation
        if (Input.GetKey(KeyCode.I))
        {
            if (rotationX < MAX_X)
                rotationX += rotationXFactor;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.K))
        {
            if (rotationX > MIN_X)
                rotationX -= rotationXFactor;

            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }

        // distance manipulation
        if (Input.GetKey(KeyCode.O))
        {
            var posX = camera.transform.localPosition.x;
            var posY = camera.transform.localPosition.y;

            if (distance < MIN_DIST)
                distance += distanceFactor;

            camera.transform.localPosition = new Vector3(posX, posY, distance);
        }
        if (Input.GetKey(KeyCode.P))
        {
            var posX = camera.transform.localPosition.x;
            var posY = camera.transform.localPosition.y;

            if (distance > MAX_DIST)
                distance -= distanceFactor;

            camera.transform.localPosition = new Vector3(posX, posY, distance);
        }
    }
}
