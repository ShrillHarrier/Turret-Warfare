using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlane : MonoBehaviour
{
    public GameObject plane;
    public double range = 20;
    private int planehealth = 3;
    void Start()
    {

    }

    /*void OnTriggerEnter(Collision2D col)
    {
        Destroy(plane);
        Debug.Log("Collision");
    }*/

    // Update is called once per frame
    void Update()
    {
        if ((plane.transform.position.magnitude >= range) || planehealth == 0)
        {
            Destroy(plane);
        }

        //if()
    }
}
