using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraSwitch : MonoBehaviour
{

    public Camera cam1, cam2,cam3;

   
    // Start is called before the first frame update
    void Start()
    {
        cam1.enabled = true;
        cam2.enabled = false;
        cam3.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Cam1On()
    {
        cam1.enabled = true;
       

    }

   public void Cam1Off()
    {
        cam1.enabled = false;


    }

    public void Cam2On()
    {
        cam2.enabled = true;
    


    }

   public void Cam2Off()
    {

        cam2.enabled = false;
    }

   public void Cam3On()
   {
       cam3.enabled = true;

   }


   public void Cam3Off()
   {

       cam3.enabled = false;
   }
}
