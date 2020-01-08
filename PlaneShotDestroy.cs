using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneShotDestroy : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject planeshot;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (planeshot.transform.position.magnitude <= 0.1)
        {
            Destroy(planeshot);
            PlayerHeath.currenthealth--;
        }
    }
}
