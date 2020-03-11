using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpController : MonoBehaviour
{
    public int PickUpCount;
    public GameObject PickUp;

    private float Y;
    private float Z;
    public float YVon;
    public float YBis;
    public float ZVon;
    public float ZBis;
    private Vector3 SpawnArea;
    void Start()
    {   
        for(int i = 0; i < PickUpCount; i++)
        {
            Y = Random.Range(YVon,YBis);
            Z = Random.Range(ZVon,ZBis);
            SpawnArea = new Vector3(0,Y,Z);
            
            Instantiate(PickUp, SpawnArea, Quaternion.identity);
        }
    }

    
}
