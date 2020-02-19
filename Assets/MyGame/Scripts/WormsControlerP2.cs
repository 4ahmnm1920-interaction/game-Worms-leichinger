using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WormsControlerP2 : MonoBehaviour
{
    public Rigidbody rb;
    public float jumphigth;
    public float walkspeed;

    public Rigidbody projectile;
    public float Ammospeed;
    public Transform Spawnpoit;  

    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode ShootKey;

    void Start()
    {

    }

    void Update()
    {
        if(Input.GetKeyDown(JumpKey))
        {
            rb.drag = 0;
            Vector3 jump = new Vector3(0, jumphigth, 0);
            rb.AddForce(jump);

        }

        if(Input.GetKey(RightKey))
        {
            rb.drag = 0;
            Vector3 forwoard = new Vector3(0, 0, walkspeed);
            rb.AddForce(forwoard);
            transform.eulerAngles = new Vector3(0,0,0);
             if(Ammospeed<1)
            {
                Ammospeed = (Ammospeed*(-1));
            }
        }

         if(Input.GetKey(LeftKey))
        {
            rb.drag = 0;
            Vector3 backwards = new Vector3(0, 0, -walkspeed);
            rb.AddForce(backwards);
            transform.eulerAngles = new Vector3(0,180,0);
            if(Ammospeed>1)
            {
                Ammospeed = (Ammospeed*(-1));
            }
        }

        if(Input.GetKeyUp(RightKey))
        {
            rb.drag = 20;
        }

         if(Input.GetKeyUp(LeftKey))
        {
            rb.drag = 20;
        }

        if (Input.GetKeyDown(ShootKey))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, Spawnpoit.position, transform.rotation);
            Vector3 pSpeed  = new Vector3(0, 0, Ammospeed);

            clone.AddForce(pSpeed);
        }
    
        /// <summary>
        /// OnTriggerEnter is called when the Collider other enters the trigger.
        /// </summary>
        /// <param name="other">The other Collider involved in this collision.</param>
        void OnTriggerEnter(Collider other)
        {
            
        }

    }
}
