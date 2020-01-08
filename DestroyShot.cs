using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyShot : MonoBehaviour
{

    public GameObject bullet;
    public double range = 10;
    void Start()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Enemy"))
        {
            Destroy(bullet);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(bullet.transform.position.magnitude >= range)
        {
            Destroy(bullet); 
        }
    }
}
