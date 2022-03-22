using UnityEngine;

public class MapScroll : MonoBehaviour
{
    public float ScrollSpeed;
    
    void Update()
    {
        transform.Translate(ScrollSpeed * Time.deltaTime, 0, 0);
        
        if(transform.position.x > 36f)
        {
            transform.position = new Vector3(0, 0, 0);
        }
    }
}
