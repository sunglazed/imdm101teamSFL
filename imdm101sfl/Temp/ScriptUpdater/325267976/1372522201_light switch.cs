using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    private float timecounter = 1.5f;
    private float starttime = 0.0f;
   [SerializeField] GameObject light = null;

    // Start is called before the first frame update
    void Start()
    {
        starttime = Time.time + timecounter;
    }

    // Update is called once per frame
    void Update()
    {
        if (starttime <= Time.time) {
            if (light.GetComponent<Renderer>().enabled == true){
                light.GetComponent<Renderer>().enabled = true;

            }
            else {
                light.GetComponent<Renderer>().enabled = false;
            }

            starttime = Time.time + timecounter;
        }
        
    }
}
