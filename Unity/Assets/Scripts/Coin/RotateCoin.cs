using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCoin
    : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    int rotateSpeed = 4;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, rotateSpeed, 0, Space.World);
    }
}
