using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShotDestroy : MonoBehaviour
{
    public GameObject tankshot;

    /*void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Player"))
        {
            Destroy
        }
    }*/

    void Update()
    {
        if(tankshot.transform.position.magnitude <= 0.1)
        {
            Destroy(tankshot);
            PlayerHeath.currenthealth -= 3;
        }
    }

}
