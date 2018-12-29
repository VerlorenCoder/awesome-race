using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControl : MonoBehaviour {

    public List<Camera> Cameras;
    public int CurrentCameraIndex = 0;

    private void Start()
    {
        Cameras[CurrentCameraIndex].depth = 999;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.C))
        {
            CurrentCameraIndex = (CurrentCameraIndex + 1) % Cameras.Count;

            Cameras.ForEach(c =>
            {
                var index = Cameras.IndexOf(c);
 
                if (index == CurrentCameraIndex)
                {
                    c.depth = 999;
                } else
                {
                    c.depth = 0;
                }
            });
        }
    }
}
