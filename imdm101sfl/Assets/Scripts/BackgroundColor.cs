using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundColor : MonoBehaviour
{
    [SerializeField] private Camera cameraRef;
    private Color day;
    private Color night;
    private Color currentColor;
    // Start is called before the first frame update
    private void Awake()
    {
        cameraRef = Camera.main;
        day = new Color(135f/255, 206f/255, 235f/255, 1f/255);
        night = new Color(10f/255, 11f/255, 58f/255, 1f/255);
        cameraRef.backgroundColor = day;
        currentColor = day;
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space)){
            if(currentColor == day){
                currentColor = night;
            }
            else{
                currentColor = day;
            }
        }
        cameraRef.backgroundColor = Color.Lerp(cameraRef.backgroundColor, currentColor, 0.007f);
    }
}
