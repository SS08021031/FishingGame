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
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;
            //�@1���o����A�e�L�X�g�Ɂu���v�����@

            case 2:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 3:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 4:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 5:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 6:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 7:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 8:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 9:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 10:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 11:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 12:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 13:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 14:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 15:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 16:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 17:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 18:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;


            case 19:
                Invoke("Deleate", DeleatTime);
                FishMozi.text = "��";
                break;

            case 20:
                Invoke("Deleate", DeleatTime);
                FishMozi.text = "��";
                break;

            case 21:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 22:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 23:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 24:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 25:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 26:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 27:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 28:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 29:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 30:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 31:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 32:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 33:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 34:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 35:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 36:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 37:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 38:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 39:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 40:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 41:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 42:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 43:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 44:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 45:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;

            case 46:
                FishMozi.text = "��";
                Invoke("Deleate", DeleatTime);
                break;
        }
    }

    void Deleate()
    {
        Destroy(this.gameObject);
    }
}
