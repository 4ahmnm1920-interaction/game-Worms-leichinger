using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsControlerP1 : MonoBehaviour
{
    public Rigidbody rb;
    public float jumphigth;
    public float walkspeed;

    public Rigidbody projectile;
    public float Ammospeed;
    public Transform spawnpoint;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            rb.drag = 0;
            Vector3 jump = new Vector3(0, jumphigth, 0);
            rb.AddForce(jump);

        }

        if(Input.GetKey(KeyCode.D))
        {
            rb.drag = 0;
            Vector3 forwoard = new Vector3(0, 0, walkspeed);
            rb.AddForce(forwoard);

        }

         if(Input.GetKey(KeyCode.A))
        {
            //transform
            rb.drag = 0;
            Vector3 backwards = new Vector3(0, 0, -walkspeed);
            rb.AddForce(backwards);

        }

        if(Input.GetKeyUp(KeyCode.D))
        {
            rb.drag = 20;
        }

         if(Input.GetKeyUp(KeyCode.A))
        {
            rb.drag = 20;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, spawnpoint.position, transform.rotation);

            Vector3 pSpeed  = new Vector3(0, 0, Ammospeed);

            clone.AddForce(pSpeed);
        }
    
    }
}
