using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneShot : MonoBehaviour
{
    public GameObject plane;
    public Rigidbody2D planeshot;
    private float firerate = 200;
    private float creationrange = 7.5f;
    public float planeshotspeed = 10;
    private bool haspassed = false;

    void Start()
    {

    }

    void Update()
    {
        float num = Random.Range(0, firerate);

        if (plane.transform.position.magnitude <= 0.1)
        {
            haspassed = true;
        }

        if (num <= 5.0 && plane.transform.position.magnitude < creationrange && haspassed == false)
        {
            Vector3 position = plane.transform.position;
            Vector3 direction = -1 * position.normalized;
            Quaternion rotation;

            rotation = Quaternion.Euler(0, 0, Vector3.Angle(direction, new Vector3(0, 1)));

            Rigidbody2D shotInstance = Instantiate(planeshot, position, rotation);
            shotInstance.velocity = direction * planeshotspeed;
        }
    }
}
