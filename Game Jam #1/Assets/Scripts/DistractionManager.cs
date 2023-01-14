using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistractionManager : MonoBehaviour
{
    // This is like a lock.

    public ObjectClick distraction;
    public ProgressionUI progUI; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (distraction == null) {
            // Debug.Log("PAUSING ON: " + distraction.distractionName);
            progUI.DistractIndicator(false);
        } else {
            progUI.DistractIndicator(true);
        }
    }
}
