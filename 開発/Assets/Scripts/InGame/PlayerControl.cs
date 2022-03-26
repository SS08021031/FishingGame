using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool Fish;
    void Start()
    {
        fish = false;
    }

    
    void Update()
    {

        if(Input.GetKey(KeyCode.Space))

        if (Input.GetKey(KeyCode.Space))

        {
            fish = true;
        }
        else
        {
            fish = false;
        }
    }   
}
