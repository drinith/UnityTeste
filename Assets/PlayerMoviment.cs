using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoviment : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce;

    public float sidewaysForce;

    private float count=0;   

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
        rb.AddForce(0,0,(forwardForce)*Time.deltaTime);
      

        if(Input.GetKey("s"))
        {
            rb.AddForce(0,0,-forwardForce*Time.deltaTime);
        }
        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0);
        }
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0);
        }
        
    }


    
}
