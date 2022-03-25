using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class    WheelControl2 : MonoBehaviour
{
    public GameObject prefab;

    public GameObject prefab1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            Instantiate(prefab, transform.position, transform.rotation);

            Instantiate(prefab1, transform.position, transform.rotation);
        }
    }
}
