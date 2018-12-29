using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatCameraControl : MonoBehaviour {

	void Update () {
        if (Input.GetKey(KeyCode.N))
        {
            transform.localPosition += Vector3.down * 0.2f;
        }
        if (Input.GetKey(KeyCode.M))
        {
            transform.localPosition += Vector3.up * 0.2f;
        }
    }
}
