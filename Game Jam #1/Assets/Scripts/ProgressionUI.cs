using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressionUI : MonoBehaviour
{
    // Word Count
    private const int maximum = 1500;
    private const int minimum = 0;
    private Text essayWordCountText;
    public GameObject essayWordObj;
    public GameObject timeObj;
    public GameObject distractObj;
    private Text distractText;
    private Text timeText;
    private int hour;
    private int minute;
    
    // Start is called before the first frame update
    void Start()
    {
        essayWordCountText = essayWordObj.GetComponent<Text>();
        essayWordCountText.text = "Word Count: " + minimum;
        timeText = timeObj.GetComponent<Text>();
        timeText.text = "Time Elapsed: " + "00:00";
        distractText = distractObj.GetComponent<Text>();
        distractText.text = "You're writing";
    }

    public void UpdateWordCountText(int wordCount)
    {
        essayWordCountText.text = "Word Count: " + wordCount;
    }
    public void UpdateTimeText(int timeCount)
    {
        Debug.Log(timeCount);
        hour = timeCount / 60;
        minute = timeCount % 60;
        if (minute < 10)
        {
            if (hour < 10)
            {
                timeText.text = "Time Elapsed: " + "0" + hour + ":" + "0" + minute;
            }
            else {
                timeText.text = "Time Elapsed: " + hour + ":" + "0" + minute;
            }
        }
        else
        {
            if (hour < 10)
            {
                timeText.text = "Time Elapsed: " + "0" + hour + ":" + minute;
            }
            else {
                timeText.text = "Time Elapsed: " + hour + ":" + minute;
            }
        }
    }

    public void DistractIndicator(bool distracted) 
    {
        if (distracted) {
            distractText.text = "You are distracted!";
        }
        else {
            distractText.text = "You're writing";
        }
    }
}
