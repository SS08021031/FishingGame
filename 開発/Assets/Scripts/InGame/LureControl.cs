using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LureControl : MonoBehaviour
{
    public GameObject target;

    public GameObject player;

    [SerializeField] float speed;

    private float power;
   
    public Slider slider;
    void Start()
    {
        player = GameObject.Find("Player");

        target = player;

       

        

        
    }

   
    void Update()
    {   
        

        

        

            if (player.GetComponent<PlayerControl>().fish)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
        }
        
        
    }
}
