using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawn : MonoBehaviour
{
    public Rigidbody2D tank;
    public int range = 10;
    public float tankspeed = 1.0F;
    private double spawnrate = 4.0;
    private double spawntime = 0.01;
    private int tanklimit = 5;
    public static int tankcount = 0;

    void Start()
    {
        
    }

    void Update()
    {
        if (((int)Time.time % spawnrate == 0 && Time.time - Mathf.Floor(Time.time) < spawntime) && tankcount < tanklimit)
        {
            //Should use cirlce instead
            float x = Random.Range(5, range);
            float y = Mathf.Sqrt(range * range - x * x);

            int xneg = Random.Range(0, 2);
            //Debug.Log(xneg);
            if (xneg == 1)
            {
                x *= -1;
            }

            int yneg = Random.Range(0, 2);
            //Debug.Log(yneg);
            if (yneg == 1)
            {
                y *= -1;
            }

            //Debug.Log(x);
            //Debug.Log(y);

            Vector3 position = new Vector3(x, y);
            Vector3 direction = -1 * position.normalized;
            Quaternion rotation;

            if (x > 0)
            {
                rotation = Quaternion.Euler(0, 0, Vector3.Angle(direction, new Vector3(0, 1)));
            }
            else
            {
                rotation = Quaternion.Euler(0, 0, 360 - Vector3.Angle(direction, new Vector3(0, 1)));
            }

            Rigidbody2D tankInstance = Instantiate(tank, position, rotation) as Rigidbody2D;
            tankInstance.velocity = direction * tankspeed;

            tankcount++;

            Debug.Log(tankcount);
        }
    }
}
