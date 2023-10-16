using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float timecounter = 0;

    float speed; 
    float width; 
    float height;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        width = 20;
        height = 10;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed;
        float x = Mathf.Cos (timecounter) * width;
        float y = Mathf.Sin (timecounter) * height;
        float z = 0;

        transform.position = new Vector3(x,y,z);
    }
}
