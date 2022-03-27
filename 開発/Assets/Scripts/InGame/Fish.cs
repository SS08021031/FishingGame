using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    [SerializeField] private GameObject fish;
    [SerializeField] private Text FishMozi;


    private float Randommozi;
    void Start()
    {
        Randommozi = Random.Range(1, 46);
    }

    void Update()
    {
        switch (Randommozi)
        {
            case 1:
                FishMozi.text = "あ";
                break;
            //　1が出たら、テキストに「あ」を代入　

            case 2:
                FishMozi.text = "い";
                break;

            case 3:
                FishMozi.text = "う";
                break;

            case 4:
                FishMozi.text = "え";
                break;

            case 5:
                FishMozi.text = "お";
                break;

            case 6:
                FishMozi.text = "か";
                break;

            case 7:
                FishMozi.text = "き";
                break;

            case 8:
                FishMozi.text = "く";
                break;

            case 9:
                FishMozi.text = "け";
                break;

            case 10:
                FishMozi.text = "こ";
                break;

            case 11:
                FishMozi.text = "さ";
                break;

            case 12:
                FishMozi.text = "し";
                break;

            case 13:
                FishMozi.text = "す";
                break;

            case 14:
                FishMozi.text = "せ";
                break;

            case 15:
                FishMozi.text = "そ";
                break;

            case 16:
                FishMozi.text = "た";
                break;

            case 17:
                FishMozi.text = "ち";
                break;

            case 18:
                FishMozi.text = "つ";
                break;


            case 19:
                FishMozi.text = "て";
                break;

            case 20:
                FishMozi.text = "と";
                break;

            case 21:
                FishMozi.text = "な";
                break;

            case 22:
                FishMozi.text = "に";
                break;

            case 23:
                FishMozi.text = "ぬ";
                break;

            case 24:
                FishMozi.text = "ね";
                break;

            case 25:
                FishMozi.text = "の";
                break;

            case 26:
                FishMozi.text = "は";
                break;

            case 27:
                FishMozi.text = "ひ";
                break;

            case 28:
                FishMozi.text = "ふ";
                break;

            case 29:
                FishMozi.text = "へ";
                break;

            case 30:
                FishMozi.text = "ほ";
                break;

            case 31:
                FishMozi.text = "ま";
                break;

            case 32:
                FishMozi.text = "み";
                break;

            case 33:
                FishMozi.text = "む";
                break;

            case 34:
                FishMozi.text = "め";
                break;

            case 35:
                FishMozi.text = "も";
                break;

            case 36:
                FishMozi.text = "や";
                break;

            case 37:
                FishMozi.text = "ゆ";
                break;

            case 38:
                FishMozi.text = "よ";
                break;

            case 39:
                FishMozi.text = "ら";
                break;

            case 40:
                FishMozi.text = "り";
                break;

            case 41:
                FishMozi.text = "る";
                break;

            case 42:
                FishMozi.text = "れ";
                break;

            case 43:
                FishMozi.text = "ろ";
                break;

            case 44:
                FishMozi.text = "わ";
                break;

            case 45:
                FishMozi.text = "を";
                break;

            case 46:
                FishMozi.text = "ん";
                break;
        }
    }
}
