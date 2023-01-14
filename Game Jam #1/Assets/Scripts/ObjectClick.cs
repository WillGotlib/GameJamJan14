using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    public string distractionName;
    public float distractionTime = 5f;
    public DistractionManager distractionManager;
    public WordCountManager wordCountManager;

    // Start is called before the first frame update
    void Start()
    {
        // distractionManager = GameObject.find("CurrentDistraction").GetComponent<DistractionManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        // t$$anonymous$$s object was clicked - do somet$$anonymous$$ng
        Debug.Log("Object was clicked");
        if (distractionManager.distraction == null) {
            distractionManager.distraction = this;
            StartCoroutine(Test());
        }
    } 

    IEnumerator Test()
    {
        /* STOP PROGRESS BAR HERE */
        wordCountManager.distracted = true;

        yield return new WaitForSeconds(distractionTime);
        
        /* RESUME PROGRESS BAR HERE */
        wordCountManager.distracted = false;
        distractionManager.distraction = null;
        Debug.Log("Object click expired.");
    }
}
