using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ladder : MonoBehaviour
{
    public GameObject player;
    public Rigidbody playerbody;
    private float speed = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  void OnTriggerStay(Collider other)
    {
     //   Debug.Log("in there");
        if (Input.GetKey(KeyCode.W))
        {
                
         //   Debug.Log("in there");
            player.transform.Translate(new Vector3(0, 1, 0) * Time.deltaTime * speed);
        }
        
    }
}
