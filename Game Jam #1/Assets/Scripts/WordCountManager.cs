using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordCountManager : MonoBehaviour
{
    public float wordCounter;
    public ProgressionUI progUI; 
    public bool distracted;
    private const float epsilon = 0.5f;
    // Start is called before the first frame update

    void Start()
    {
        wordCounter = 0;
        progUI = GameObject.FindObjectOfType<ProgressionUI>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (!distracted) 
        {
            wordCounter += 0.04f;

            if (wordCounter % 1 < epsilon) {
                progUI.UpdateWordCountText((int)wordCounter);
            }
        }
    }
  

}

