using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour
{
    public GameObject tank;
    public ParticleSystem explosion;
    private int health = 5;

    void OnTriggerEnter2D(Collider2D collider)
        {
            if (collider.tag.Equals("Shot"))
            {
                health--;
            }
            if (health == 0)
            {
                Vector3 position = tank.transform.position;
                Destroy(tank);
                ParticleSystem boominstance = Instantiate(explosion, position, Quaternion.identity);
                Score.currentscore += 2;
                TankSpawn.tankcount--;
        }
    }

}
