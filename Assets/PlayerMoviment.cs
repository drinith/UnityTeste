﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 200f;
    

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(500*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-500*Time.deltaTime,0,0);
        }
        
    }


    
}
