using UnityEngine;
using UnityEngine.UI;

public class Player1_Thema : MonoBehaviour
{
    private float RandomThema;

    [SerializeField] private Text thema;
    void Start()
    {
        RandomThema = Random.Range(1, 3);
    }

    void Update()
    {
        switch (RandomThema)
        {
            case 1:
                thema.text = "川";
                break;
            //　1が出たら、テキストに「川」を代入　

            case 2:
                thema.text = "麺";
                break;
        }
    }
}
