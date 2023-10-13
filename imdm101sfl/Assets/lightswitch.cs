using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightswitch : MonoBehaviour
{
    Light light;
    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp (KeyCode.Space)){
            light.enabled = !light.enabled;
        }
    }
}
