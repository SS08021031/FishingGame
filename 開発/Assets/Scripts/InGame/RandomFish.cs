
using UnityEngine;

public class RandomFish : MonoBehaviour
{
    public GameObject FishPrefabs;

    public float X_min;
    public float X_max;

    public float Y_min;
    public float Y_max;

    public float count;
    void Start()
    {
        
    }

    void Update()
    {
        count++;

        if(count >= 5)
        {
            float x = Random.Range(X_min, X_max);
            float y = Random.Range(Y_min, Y_max);
            Vector2 pos = new Vector2(x, y);

            Instantiate(FishPrefabs, pos, Quaternion.identity);
        }
    }
}
