using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeGame : MonoBehaviour
{
    float roundStartDelayTime = 3;
    float roundStartTime;
    int waitTime;
    // bool's automatically set to false
    bool roundStarted;

    // Start is called before the first frame update
    void Start()
    {
        print("Press the spacebar when you think the time is up. You probs can't do it.");
        // pass in string for name of method and a float for the time for that method to start
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && roundStarted) 
        {
            InputReceived ();
        } 
    }

    void InputReceived()
    {
        roundStarted = false;
        float playerWaitTime = Time.time - roundStartTime;
        float error = Mathf.Abs(waitTime - playerWaitTime);

        print("You took " + playerWaitTime + " Seconds. That's " + error + " seconds off! " + GenerateMessage(error));
        Invoke("SetNewRandomTime", roundStartDelayTime);
    }

    string GenerateMessage(float error)
    {
        string message = "";
        if (error < .15f)
        {
            message = "You must have cheated...";
        }
        else if (error < .75f)
        {
            message = "Cut the energy drinks man, thats pretty damn close.";
        }
        else if (error < 1.25f)
        {
            message = "Dang couldnt quite get the second.";
        }
        else if (error < 1.75f)
        {
            message = "Thats almost two seconds, what're you drunk?";
        }
        else if (error < 2.75f)
        {
            message = "Wow. absolutely terrible!";
        }
        else
        {
            message = "That was trash";
        }
        
        return message;
    }

    void SetNewRandomTime()
    {
        waitTime = Random.Range(5, 21);
        roundStartTime = Time.time;
        roundStarted = true;

        print(waitTime + " seconds.");
    }
}
