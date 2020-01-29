using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsControler : MonoBehaviour
{
    public Rigidbody rb;
    public float jumphigth;
    public float walkspeed;
    
    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 jump = new Vector3(0, jumphigth, 0);
            rb.AddForce(jump);

        }

        if(Input.GetKey(KeyCode.D))
        {
            Vector3 forwoard = new Vector3(0, 0, walkspeed);
            rb.AddForce(forwoard);

        }

         if(Input.GetKey(KeyCode.A))
        {
            Vector3 backwards = new Vector3(0, 0, -walkspeed);
            rb.AddForce(backwards);

        }
    
    }
}
