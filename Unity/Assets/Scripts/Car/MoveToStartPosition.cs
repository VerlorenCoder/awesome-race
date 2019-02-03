using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;
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
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }


    
}
