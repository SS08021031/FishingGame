using UnityEngine;
using UnityEngine.UI;

public class TextDate : MonoBehaviour
{
    [SerializeField]
    private Transform targetTfm;

    private RectTransform myRectTfm;
    private Vector3 offset = new Vector3(0, 0, 0);

    void Start()
    {
        myRectTfm = GetComponent<RectTransform>();
    }

    void Update()
    {
        myRectTfm.position
            = RectTransformUtility.WorldToScreenPoint(Camera.main, targetTfm.position + offset);
    }
}

//テキストが魚の画像の上に表示されるようにしている
//New Vectoe3(?, ?, ?)・・・？の部分の数字を変えれば、表示する位置を変えられる
