using UnityEngine;

public class MapScroll : MonoBehaviour
{
    public float ScrollSpeed;
    //スクロールのスピード
    
    void Update()
    {
        transform.Translate(ScrollSpeed * Time.deltaTime, 0, 0);
        //スクロールスピード×時間　右に進む

        if(transform.position.x > 36f)
        //ポジションのX値が36より大きくなったら
        {
            transform.position = new Vector3(0, 0, 0);
            //もとの場所に戻る
        }
    }
}
