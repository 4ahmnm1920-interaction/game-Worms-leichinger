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
    public Transform Spawnpoit;

    public KeyCode JumpKey;
    public KeyCode LeftKey;
    public KeyCode RightKey;
    public KeyCode ShootKey;

    public float dynFriction;
     public float statFriction;
     public CapsuleCollider coll;

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
            coll = GetComponent<CapsuleCollider>();
            coll.material.dynamicFriction = 0;
            coll.material.staticFriction = 0;

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
            coll = GetComponent<CapsuleCollider>();
            coll.material.dynamicFriction = 0;
            coll.material.staticFriction = 0;

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
            coll = GetComponent<CapsuleCollider>();
            coll.material.dynamicFriction = dynFriction;
            coll.material.staticFriction = statFriction;
        }

        if(Input.GetKeyUp(LeftKey))
        {
            coll = GetComponent<CapsuleCollider>();
            coll.material.dynamicFriction = dynFriction;
            coll.material.staticFriction = statFriction;
        }

        

        if (Input.GetKeyDown(ShootKey))
        {
            Rigidbody clone;
            clone = Instantiate(projectile, Spawnpoit.position, transform.rotation);
            Vector3 pSpeed  = new Vector3(0, 0, Ammospeed);

            clone.AddForce(pSpeed);
        }
    
    }
}
