using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public cameraSwitch cams;
    public String methodname;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (methodname == "Camera 1")
        {
            if (other.gameObject.tag == "Player")
            {
                cams.Cam1On();
                cams.Cam2Off();

            }
          
        }
        
        
        if (methodname == "Camera 2")
        {
            if (other.gameObject.tag == "Player")
            {
                cams.Cam2On();
                cams.Cam1Off();
            }
         
        }
    }
}
