using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getoffLadder : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject player;
    private float speed = 50;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("in");
        player.transform.Translate(new Vector3(0, 1, 2) * Time.deltaTime * speed);
        
    }
}
