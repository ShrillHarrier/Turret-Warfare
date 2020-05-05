using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneCollision : MonoBehaviour
{
    public GameObject plane;
    public ParticleSystem explosion;
    private int health = 3;

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag.Equals("Shot"))
        {
            health--;
        }
        if (health == 0)
        {
            Vector3 position = plane.transform.position;
            Destroy(plane);
            ParticleSystem boominstance = Instantiate(explosion, position, Quaternion.identity);
            Score.currentscore++;
        }
    }
}

