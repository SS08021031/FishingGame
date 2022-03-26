using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public bool fish;
    void Start()
    {
        fish = false;
    }

    
    void Update()
    {
<<<<<<< HEAD:開発/Assets/Scripts/PlayerControl.cs
        if(Input.GetKey(KeyCode.Space))
=======
        if (Input.GetKey(KeyCode.Space))
>>>>>>> 25079114971c1191f6469d5d7ef23a9ad9c4533d:開発/Assets/Scripts/InGame/PlayerControl.cs
        {
            fish = true;
        }
        else
        {
            fish = false;
        }
    }   
}
