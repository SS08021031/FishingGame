using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class    WheelControl2 : MonoBehaviour
{
    public GameObject prefab1;

    public GameObject prefab2;

    public GameObject prefab3;

   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(prefab1, transform.position, transform.rotation);

            Instantiate(prefab2, transform.position, transform.rotation);

            Instantiate(prefab3, transform.position + new Vector3(0, 5,0), transform.rotation);
        }
    }
}
