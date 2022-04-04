using UnityEngine;
using UnityEngine.UI;

public class Fish : MonoBehaviour
{
    [SerializeField] private Text FishMozi;

    private float Randommozi;

    public float DeleatTime;
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
                Invoke("Deleate", DeleatTime);
                break;
            //　1が出たら、テキストに「あ」を代入　

            case 2:
                FishMozi.text = "い";
                Invoke("Deleate", DeleatTime);
                break;

            case 3:
                FishMozi.text = "う";
                Invoke("Deleate", DeleatTime);
                break;

            case 4:
                FishMozi.text = "え";
                Invoke("Deleate", DeleatTime);
                break;

            case 5:
                FishMozi.text = "お";
                Invoke("Deleate", DeleatTime);
                break;

            case 6:
                FishMozi.text = "か";
                Invoke("Deleate", DeleatTime);
                break;

            case 7:
                FishMozi.text = "き";
                Invoke("Deleate", DeleatTime);
                break;

            case 8:
                FishMozi.text = "く";
                Invoke("Deleate", DeleatTime);
                break;

            case 9:
                FishMozi.text = "け";
                Invoke("Deleate", DeleatTime);
                break;

            case 10:
                FishMozi.text = "こ";
                Invoke("Deleate", DeleatTime);
                break;

            case 11:
                FishMozi.text = "さ";
                Invoke("Deleate", DeleatTime);
                break;

            case 12:
                FishMozi.text = "し";
                Invoke("Deleate", DeleatTime);
                break;

            case 13:
                FishMozi.text = "す";
                Invoke("Deleate", DeleatTime);
                break;

            case 14:
                FishMozi.text = "せ";
                Invoke("Deleate", DeleatTime);
                break;

            case 15:
                FishMozi.text = "そ";
                Invoke("Deleate", DeleatTime);
                break;

            case 16:
                FishMozi.text = "た";
                Invoke("Deleate", DeleatTime);
                break;

            case 17:
                FishMozi.text = "ち";
                Invoke("Deleate", DeleatTime);
                break;

            case 18:
                FishMozi.text = "つ";
                Invoke("Deleate", DeleatTime);
                break;


            case 19:
                Invoke("Deleate", DeleatTime);
                FishMozi.text = "て";
                break;

            case 20:
                Invoke("Deleate", DeleatTime);
                FishMozi.text = "と";
                break;

            case 21:
                FishMozi.text = "な";
                Invoke("Deleate", DeleatTime);
                break;

            case 22:
                FishMozi.text = "に";
                Invoke("Deleate", DeleatTime);
                break;

            case 23:
                FishMozi.text = "ぬ";
                Invoke("Deleate", DeleatTime);
                break;

            case 24:
                FishMozi.text = "ね";
                Invoke("Deleate", DeleatTime);
                break;

            case 25:
                FishMozi.text = "の";
                Invoke("Deleate", DeleatTime);
                break;

            case 26:
                FishMozi.text = "は";
                Invoke("Deleate", DeleatTime);
                break;

            case 27:
                FishMozi.text = "ひ";
                Invoke("Deleate", DeleatTime);
                break;

            case 28:
                FishMozi.text = "ふ";
                Invoke("Deleate", DeleatTime);
                break;

            case 29:
                FishMozi.text = "へ";
                Invoke("Deleate", DeleatTime);
                break;

            case 30:
                FishMozi.text = "ほ";
                Invoke("Deleate", DeleatTime);
                break;

            case 31:
                FishMozi.text = "ま";
                Invoke("Deleate", DeleatTime);
                break;

            case 32:
                FishMozi.text = "み";
                Invoke("Deleate", DeleatTime);
                break;

            case 33:
                FishMozi.text = "む";
                Invoke("Deleate", DeleatTime);
                break;

            case 34:
                FishMozi.text = "め";
                Invoke("Deleate", DeleatTime);
                break;

            case 35:
                FishMozi.text = "も";
                Invoke("Deleate", DeleatTime);
                break;

            case 36:
                FishMozi.text = "や";
                Invoke("Deleate", DeleatTime);
                break;

            case 37:
                FishMozi.text = "ゆ";
                Invoke("Deleate", DeleatTime);
                break;

            case 38:
                FishMozi.text = "よ";
                Invoke("Deleate", DeleatTime);
                break;

            case 39:
                FishMozi.text = "ら";
                Invoke("Deleate", DeleatTime);
                break;

            case 40:
                FishMozi.text = "り";
                Invoke("Deleate", DeleatTime);
                break;

            case 41:
                FishMozi.text = "る";
                Invoke("Deleate", DeleatTime);
                break;

            case 42:
                FishMozi.text = "れ";
                Invoke("Deleate", DeleatTime);
                break;

            case 43:
                FishMozi.text = "ろ";
                Invoke("Deleate", DeleatTime);
                break;

            case 44:
                FishMozi.text = "わ";
                Invoke("Deleate", DeleatTime);
                break;

            case 45:
                FishMozi.text = "を";
                Invoke("Deleate", DeleatTime);
                break;

            case 46:
                FishMozi.text = "ん";
                Invoke("Deleate", DeleatTime);
                break;
        }
    }

    void Deleate()
    {
        Destroy(this.gameObject);
    }
}
