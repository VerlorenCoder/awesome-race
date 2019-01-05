using System.Collections;
using UnityEngine;

public class Sun : MonoBehaviour {
    public float sunSpeed = 2f;

    public float MIN_INTENSITY = 0.0f;
    public float MAX_INTENSITY = 1.5f;

    private float currentSunHeight = 750f;
    private bool day = true;
    private bool rises = false;

    private GameObject sunObject;
    private Light sun;

    void Start() {
        sunObject = GameObject.Find("Sun");
        sun = GameObject.Find("Sun").GetComponent<Light>();
        currentSunHeight = sun.transform.position.y;
    }

    void Update() {
        float intensityChange = sunSpeed / 4000f;
        transform.RotateAround(Vector3.zero, Vector3.right, sunSpeed * Time.deltaTime);
        transform.LookAt(Vector3.zero);

        float nextSunHeight = sunObject.transform.position.y;

        if((day && nextSunHeight < 0) || (!day && nextSunHeight > 0)) {
            day = !day;
        }

        if(day && (nextSunHeight > currentSunHeight)) {
            rises = true;
        } else if(day && (nextSunHeight <= currentSunHeight)) {
            rises = false;
        }

        addIntensity(intensityChange);

        currentSunHeight = nextSunHeight;
    }

    private void addIntensity(float intensityChange) {
        if (day && rises) {
            sun.intensity += intensityChange;
        } else if (day && !rises) {
            sun.intensity -= intensityChange;
        }

        if(sun.intensity < MIN_INTENSITY) {
            sun.intensity = MIN_INTENSITY;
        }

        if(sun.intensity > MAX_INTENSITY) {
            sun.intensity = MAX_INTENSITY;
        }
    }
}
