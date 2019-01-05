using UnityEngine;
using UnityEngine.UI;

public class RaceTimer : MonoBehaviour
{
    public Text timerText;
    private float startTime = 0f;
    private bool finished = false;
    private bool started = false;
    private bool linePassed = false;
    float t;
    // Start is called before the first frame update
    void Start()
    {
        startTime= Time.time;
        timerText.text = "0:" + "0.0";
    }
    // Update is called once per frame
    void Update()
    {
        if (started)
        {

            if (finished)
            {
                started = false;
                return;
            }

            t = Time.time - startTime;
            string  minutes = ((int)t / 60).ToString();
            string  seconds = (t % 60).ToString("f1");
            timerText.text = minutes + ":" + seconds;
        }
       
    }

    void Finish()
    {
        finished = true;
        timerText.color = Color.yellow;

    }
    void TimeStart()
    {
        started = true;
        startTime = Time.time;
    }
    void TimeStop()
    {
        started = false;
        finished = false;
    }
}
