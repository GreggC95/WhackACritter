using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour {

    //Display visual timer
    public TextMesh displayText;

    //starting time for the timer
    public float timerDuration;

    //Current seconds remaining on the timer
    private float timeRemaining = 0;


    // Use this for initialization
    void Start () {
        StartTimer();
	}
	
	// Update is called once per frame
	void Update () {
        
        //Only process the timer if it is nrunning
        if (IsTimerRunning())
        {
            //Timer is ruuning, so process

            //updated the time remaining this frame
            timeRemaining = timeRemaining - Time.deltaTime;

            // check if we have now run out of time
            if(timeRemaining <= 0)
            {
                   // set our time to exacty 0
                stopTimer();
            }

            //update the visual display
            displayText.text = Mathf.CeilToInt(timeRemaining).ToString();

        }
	}

    //starts the timer counting
    public void StartTimer()
    {
        timeRemaining = timerDuration;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();
    }

    //stop the timer counting
    public void stopTimer()
    {
        timeRemaining = 0;
        displayText.text = Mathf.CeilToInt(timeRemaining).ToString();

    }

    //is the timer currently running?
    public bool IsTimerRunning()
    {
        if (timeRemaining != 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}
