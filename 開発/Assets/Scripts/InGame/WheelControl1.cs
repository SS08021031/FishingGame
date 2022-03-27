using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelControl1 : MonoBehaviour
{

    public GameObject player;
    void Start()
    {
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {   
        if(player.GetComponent<PlayerControl>().fish)
        {
                transform.Rotate(new Vector3(0, 0, -3));
        }
        
        
    }
}
