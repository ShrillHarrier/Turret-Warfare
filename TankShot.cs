using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankShot : MonoBehaviour
{
    public GameObject tank;
    public Rigidbody2D tankshot;
    private float firerate = 100;
    private float creationrange = 7.5f;
    public float tankshotspeed = 10; 
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float num = Random.Range(0,firerate);

        if(num <= 1 && tank.transform.position.magnitude < creationrange)
        {
            Vector3 position = tank.transform.position;
            Vector3 direction = -1 * position.normalized;
            Quaternion rotation;

            rotation = Quaternion.Euler(0, 0, Vector3.Angle(direction, new Vector3(0, 1)));

            Rigidbody2D shotInstance = Instantiate(tankshot, position, rotation);
            shotInstance.velocity = direction * tankshotspeed;

            /*if(shotInstance.position.magnitude >= destroyrange)
            {
                Destroy(shotInstance);
            }*/
        }
    }
}
