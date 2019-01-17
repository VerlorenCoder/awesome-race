using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCameraControl : MonoBehaviour {

    private float rotationY, rotationX;

	// Use this for initialization
	void Start () {
        rotationX = transform.localEulerAngles.x;
        rotationY = transform.localEulerAngles.y;
        transform.Rotate(rotationX, rotationY, 0);
    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.J))
        {
            rotationY += 1;
            // transform.Rotate(0, rotationY, 0);
            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.L))
        {
            rotationY -= 1;
            // transform.Rotate(0, rotationY, 0);
            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.I))
        {
            rotationX += 1;
            // transform.Rotate(rotationX, 0, 0);
            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }
        if (Input.GetKey(KeyCode.K))
        {
            rotationX -= 1;
            // transform.Rotate(rotationX, 0, 0);

            // var posX = transform.localEulerAngles.x;
            var posZ = transform.localEulerAngles.z;
            transform.localEulerAngles = new Vector3(rotationX, rotationY, posZ);
        }

    }
}
