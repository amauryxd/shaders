using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    //public float x;
    //public float y;
    //public float z;
    //public float smooth;
    public float speed;
    public float speedy;
    public float speedz;
    void Start()
    {
        
    }

    
    void Update()
    {
        //Quaternion target = Quaternion.Euler(x, y, z);
        //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime*smooth);
        transform.Rotate(speed*Time.deltaTime, speedy*Time.deltaTime, speedz*Time.deltaTime);
    }
}
