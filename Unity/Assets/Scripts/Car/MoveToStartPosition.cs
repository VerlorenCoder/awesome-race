using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class MoveToStartPosition : MonoBehaviour
{
    // Start is called before the first frame update
    public Text timerText;
    private CarController Car;

    void Start()
    {
        Car = GetComponent<CarController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            Quaternion rotation = new Quaternion(0, 0, 0, 0);
            Vector3 startPos = new Vector3(-7.39f, 1.95f, 4.6f);
            GameObject.Find("Car").transform.position = startPos;
            GameObject.Find("Car").transform.rotation = rotation;
            timerText.color = Color.white;
            timerText.text = "00:00.0";
            GameObject.Find("Car").GetComponent<CarController>().RaceStop();


        }
    }


    
}
