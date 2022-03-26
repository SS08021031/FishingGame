using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
<<<<<<< HEAD
    public bool Fish;
=======
    public bool fish;
>>>>>>> d7dfacdd21a6de9009df6400eae09dffc17d1324
    void Start()
    {
        fish = false;
    }

    
    void Update()
    {
<<<<<<< HEAD

        if(Input.GetKey(KeyCode.Space))

        if (Input.GetKey(KeyCode.Space))

=======
<<<<<<< HEAD:開発/Assets/Scripts/PlayerControl.cs
        if(Input.GetKey(KeyCode.Space))
=======
        if (Input.GetKey(KeyCode.Space))
>>>>>>> 25079114971c1191f6469d5d7ef23a9ad9c4533d:開発/Assets/Scripts/InGame/PlayerControl.cs
>>>>>>> d7dfacdd21a6de9009df6400eae09dffc17d1324
        {
            fish = true;
        }
        else
        {
            fish = false;
        }
    }   
}
