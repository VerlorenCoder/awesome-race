using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlatCameraControl : MonoBehaviour {

    public int InitialHeight = 25, MinHeight = 10, MaxHeight = 200;
    public float ZoomFactor = 0.5f;

    private void Start()
    {
        transform.position = new Vector3(transform.localPosition.x, InitialHeight, transform.localPosition.z);       
    }
    void Update () {
        var currentHeight = transform.localPosition.y;
        if (Input.GetKey(KeyCode.Z) && currentHeight > MinHeight)
        {
            transform.position += Vector3.down * ZoomFactor;
        }
        if (Input.GetKey(KeyCode.X) && currentHeight < MaxHeight)
        {
            transform.position += Vector3.up * ZoomFactor;
        }
    }
}
