using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LureControl : MonoBehaviour
{
    public GameObject target;

    [SerializeField] float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.transform.position, speed);
    }
}
