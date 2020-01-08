using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankStop : MonoBehaviour
{
    public Rigidbody2D tank;
    public double range = 3;

    void Start()
    {
        
    }

    /*void OnTriggerEnter(Collision2D col)
    {
        Destroy(tank); 
       
    }*/

    // Update is called once per frame
    void Update()
    {
        if (tank.transform.position.magnitude <= range)
        {
            tank.velocity *= 0;
        }
    }
}
