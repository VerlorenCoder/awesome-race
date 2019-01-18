using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameQuit : MonoBehaviour {

    private bool mouseDown = false;
    private float timeDown = 0.0f;

    void Update() {
        if (Input.GetButtonDown("Cancel")) {
            mouseDown = true;
        } else if(Input.GetButtonUp("Cancel")) {
            mouseDown = false;
            timeDown = 0.0f;
        }

        if (mouseDown) {
            timeDown += Time.deltaTime;

            if(timeDown > 3.0f) {
                Application.Quit();
            }
        }
    }
}
