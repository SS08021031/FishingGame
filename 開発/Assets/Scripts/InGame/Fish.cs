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
                FishMozi.text = "��";
                break;
            //�@1���o����A�e�L�X�g�Ɂu���v�����@

            case 2:
                FishMozi.text = "��";
                break;

            case 3:
                FishMozi.text = "��";
                break;

            case 4:
                FishMozi.text = "��";
                break;

            case 5:
                FishMozi.text = "��";
                break;

            case 6:
                FishMozi.text = "��";
                break;

            case 7:
                FishMozi.text = "��";
                break;

            case 8:
                FishMozi.text = "��";
                break;

            case 9:
                FishMozi.text = "��";
                break;

            case 10:
                FishMozi.text = "��";
                break;

            case 11:
                FishMozi.text = "��";
                break;

            case 12:
                FishMozi.text = "��";
                break;

            case 13:
                FishMozi.text = "��";
                break;

            case 14:
                FishMozi.text = "��";
                break;

            case 15:
                FishMozi.text = "��";
                break;

            case 16:
                FishMozi.text = "��";
                break;

            case 17:
                FishMozi.text = "��";
                break;

            case 18:
                FishMozi.text = "��";
                break;


            case 19:
                FishMozi.text = "��";
                break;

            case 20:
                FishMozi.text = "��";
                break;

            case 21:
                FishMozi.text = "��";
                break;

            case 22:
                FishMozi.text = "��";
                break;

            case 23:
                FishMozi.text = "��";
                break;

            case 24:
                FishMozi.text = "��";
                break;

            case 25:
                FishMozi.text = "��";
                break;

            case 26:
                FishMozi.text = "��";
                break;

            case 27:
                FishMozi.text = "��";
                break;

            case 28:
                FishMozi.text = "��";
                break;

            case 29:
                FishMozi.text = "��";
                break;

            case 30:
                FishMozi.text = "��";
                break;

            case 31:
                FishMozi.text = "��";
                break;

            case 32:
                FishMozi.text = "��";
                break;

            case 33:
                FishMozi.text = "��";
                break;

            case 34:
                FishMozi.text = "��";
                break;

            case 35:
                FishMozi.text = "��";
                break;

            case 36:
                FishMozi.text = "��";
                break;

            case 37:
                FishMozi.text = "��";
                break;

            case 38:
                FishMozi.text = "��";
                break;

            case 39:
                FishMozi.text = "��";
                break;

            case 40:
                FishMozi.text = "��";
                break;

            case 41:
                FishMozi.text = "��";
                break;

            case 42:
                FishMozi.text = "��";
                break;

            case 43:
                FishMozi.text = "��";
                break;

            case 44:
                FishMozi.text = "��";
                break;

            case 45:
                FishMozi.text = "��";
                break;

            case 46:
                FishMozi.text = "��";
                break;
        }
    }
}
