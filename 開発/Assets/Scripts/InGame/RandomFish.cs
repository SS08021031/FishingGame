using UnityEngine;
using UnityEngine.UI;
public class RandomFish : MonoBehaviour
{
    
    public GameObject Fish; //Fishを格納

    public float X_min;　//Ｘ軸の最小値
    public float X_max;　//Ｘ軸の最大値

    public float Y_min;　//Ｙ軸の最小値
    public float Y_max;　//Ｙ軸の最大値

    public float instantiate;　//魚が生まれる時間
    

    void Start()
    {
        InvokeRepeating("Instantiate", instantiate, instantiate);
        //Instantiateメソッドを最初はinstantiate秒後、それ以降はinstantiate秒後に繰り返す
    }

    void Instantiate()
    {
        float x = Random.Range(X_min, X_max); //Ｘ軸の最小値～最大値までの数値がランダムに出る
        float y = Random.Range(Y_min, Y_max); //Ｙ軸の最小値～最大値までの数値がランダムに出る

        Vector2 pos = new Vector2(x, y); //出たＸ軸とＹ軸の数値を新しいVector2に代入

        //新しいVector2の場所に生成する
        Instantiate(Fish, pos, transform.rotation);

        Invoke("Fishdeleate", 3);
    }

    void Fishdeleate()
    {

    }
}
