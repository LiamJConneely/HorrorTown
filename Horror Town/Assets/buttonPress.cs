using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buttonPress : MonoBehaviour
{
    public GameObject bridge;
    // Start is called before the first frame update
    void Start()
    {
        bridge.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            
            bridge.SetActive(true);
            
        }
        
    }
}
