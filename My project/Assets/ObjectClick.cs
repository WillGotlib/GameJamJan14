using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectClick : MonoBehaviour
{
    
    public float distractionTime = 5f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnMouseDown()
    {
        // t$$anonymous$$s object was clicked - do somet$$anonymous$$ng
        Debug.Log("Object was clicked");
        StartCoroutine(Test());
        // Destroy (t$$anonymous$$s.gameObject);
    } 

    IEnumerator Test()
    {
        /* STOP PROGRESS BAR HERE */
        yield return new WaitForSeconds(5f);
        
        /* RESUME PROGRESS BAR HERE */
        Debug.Log("Object click expired.");
    }
}
