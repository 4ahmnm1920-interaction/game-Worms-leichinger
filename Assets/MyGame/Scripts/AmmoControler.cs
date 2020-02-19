using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoControler : MonoBehaviour
{
    public GameObject AmmoObject;
    public float DelayTime = 2f;

    void Start()
    {
        Destroy(AmmoObject, DelayTime);
    }
}
