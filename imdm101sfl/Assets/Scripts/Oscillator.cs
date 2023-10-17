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
        speed = 1f;
        width = 1.5f;
        height = 1.5f;
    }

    // Update is called once per frame
    void Update()
    {
        timecounter += Time.deltaTime * speed;
        float z = Mathf.Cos (timecounter) * width;
        float x = Mathf.Sin (timecounter) * height;
        float y = 0;

        transform.position = new Vector3(x + (-20.4f),y + (0.2401813f),z + (-6.719656f));
        Debug.Log(Time.deltaTime);
        transform.Rotate(new Vector3(0, 78, 0) * 0.002f);
    }
}
