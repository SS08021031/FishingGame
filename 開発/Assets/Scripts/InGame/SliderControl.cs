using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderControl : MonoBehaviour
{
    public bool slider1;

    private float power;

    float dt = 0;

    public Slider slider;

    public Rigidbody rb;
    void Start()
    {
        slider1 = false;

        power = 0;

        slider.value = 0;
    }

    
    void Update()
    {
        if (Input.GetKey(KeyCode.B))
        {
            if (power < 10)
            {
                power += 0.1f;
            }

            slider.value += 0.1f;

            slider1 = false;
        }

        dt += Time.deltaTime;

        if (Input.GetKeyUp(KeyCode.B))
        {
            slider1 = true;
        }

        if (slider1)
        {
            slider.value -= 0.1f;
        }
    }
}
