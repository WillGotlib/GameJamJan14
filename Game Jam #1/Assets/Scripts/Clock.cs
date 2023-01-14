using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clock : MonoBehaviour
{
    public float clockCounter;
    public ProgressionUI progUI;
    private const float epsilon = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        clockCounter = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate() 
    {
            clockCounter += 0.05f;

            if (clockCounter % 5 < epsilon) {
                progUI.UpdateTimeText((int)clockCounter);
            }

    }
}
