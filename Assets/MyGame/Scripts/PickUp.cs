using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{   
    public WormsControler worm;
    void OnTriggerEnter(Collider other) 
        {
            if (other.gameObject.CompareTag("Player"))
            {
                worm = other.gameObject.GetComponent<WormsControler>();
                worm.rb.useGravity = false;
                Destroy(this.gameObject);
            }
        }

}
