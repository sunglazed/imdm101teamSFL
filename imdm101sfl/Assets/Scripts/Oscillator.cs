using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    float timecounter = 0;

    float speed; 
    float width; 
    float height;

    bool down;
    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
        width = 20;
        height = 10;
        down = false;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed;
        Debug.Log(timecounter);
        float x = Mathf.Cos (timecounter) * width;
        float y = Mathf.Sin (timecounter) * height;
        float z = 0;
        if(Input.GetKeyUp (KeyCode.L) && down == false)
        {
            transform.position = new Vector3 (x, Mathf.Sin(180) * height, z);
            down = true;
        }
        if(Input.GetKeyUp (KeyCode.L) && down == true)
        {
            transform.position = new Vector3 (x, Mathf.Sin(360) * height, z);
            down = false;
        }
        //transform.position = new Vector3 (x, y, z);
    }
}
