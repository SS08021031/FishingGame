using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl1 : MonoBehaviour
{
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(new Vector3(0, 0, -3));
        }
        
    }
}
