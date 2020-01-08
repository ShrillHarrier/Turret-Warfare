using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Canon : MonoBehaviour
{
	public GameObject p;
	public Rigidbody2D highbullet;
    public Rigidbody2D lowbullet;
    public float speed = 300;
    public float bulletspeed = 12;
    private float offset = 1.3f;
    
    void Start()
    {
        
    }

    void Update()
    {
        //Debug.Log((int)Time.time);

		if(Input.GetKey("a"))
        {
            p.transform.Rotate(Vector3.forward * speed * Time.deltaTime);
        }
		if(Input.GetKey("d")){
			p.transform.Rotate(-1 * Vector3.forward * speed * Time.deltaTime);
		}
		if(Input.GetKeyDown("m")){
			Vector3 position = p.transform.position;
            Quaternion rotation = p.transform.rotation;
            Vector3 direction = rotation * new Vector3(0, 1, 0);

            Rigidbody2D bulletInstance1 = Instantiate(highbullet, (position + direction)*offset, rotation) as Rigidbody2D;
            bulletInstance1.velocity = direction * bulletspeed;

            Rigidbody2D bulletInstance2 = Instantiate(lowbullet, (position + direction)*offset, rotation) as Rigidbody2D;
            bulletInstance2.velocity = direction * bulletspeed;
        }
    }
}
