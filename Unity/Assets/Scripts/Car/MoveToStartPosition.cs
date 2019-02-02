using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using UnityEngine.SceneManagement;

public class MoveToStartPosition : MonoBehaviour
{
    // public Text timerText;
    private CarController Car;

    void Start()
    {
        Car = GetComponent<CarController>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            MoveToTrack();
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            RestartGame();
        }
    }

    void MoveToTrack()
    {
        var carPosition = Car.transform.position;
        var track = GameObject.FindWithTag("Respawn");

        var children = track.GetComponentsInChildren<Transform>();

        Transform closestTrack = children[0];
        float closestDistance = Vector3.Distance(children[0].position, carPosition);

        foreach (Transform child in children)
        {
            float distance = Vector3.Distance(child.position, carPosition);
            if (distance < closestDistance)
            {
                closestDistance = distance;
                closestTrack = child;
            }
        }
        Quaternion rotation = new Quaternion(0, 0, 0, 0);
        Vector3 startPos = closestTrack.position;

        Car.transform.position = startPos;
        Car.transform.rotation = rotation;

        Car.GetComponent<Rigidbody>().velocity = new Vector3(0f, 0f, 0f);
        Car.GetComponent<Rigidbody>().angularVelocity = new Vector3(0f, 0f, 0f);
    }

    void RestartGame()
    {
        SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
    }

}
