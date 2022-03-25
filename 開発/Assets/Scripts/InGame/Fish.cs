using UnityEngine;
using UnityEngine.UI;
public class Fish : MonoBehaviour
{
    public Text FishMozi;
    private float Randommozi;

    
    void Start()
    {
        Randommozi = Random.Range(1, 46);
    }

    void Update()
    {
        
        
        switch(Randommozi)
        {
            case 1:
                FishMozi.text = "‚ ";
                break;

            case 2:
                FishMozi.text = "‚¢";
                break;

            case 3:
                FishMozi.text = "‚¤";
                break;

            case 4:
                FishMozi.text = "‚¦";
                break;

            case 5:
                FishMozi.text = "‚¨";
                break;

            case 6:
                FishMozi.text = "‚©";
                break;

            case 7:
                FishMozi.text = "‚«";
                break;

            case 8:
                FishMozi.text = "‚­";
                break;

            case 9:
                FishMozi.text = "‚¯";
                break;

            case 10:
                FishMozi.text = "‚±";
                break;

            case 11:
                FishMozi.text = "‚³";
                break;

            case 12:
                FishMozi.text = "‚µ";
                break;

            case 13:
                FishMozi.text = "‚·";
                break;

            case 14:
                FishMozi.text = "‚¹";
                break;

            case 15:
                FishMozi.text = "‚»";
                break;

            case 16:
                FishMozi.text = "‚½";
                break;

            case 17:
                FishMozi.text = "‚¿";
                break;

            case 18:
                FishMozi.text = "‚Â";
                break;


            case 19:
                FishMozi.text = "‚Ä";
                break;

            case 20:
                FishMozi.text = "‚Æ";
                break;

            case 21:
                FishMozi.text = "‚È";
                break;

            case 22:
                FishMozi.text = "‚É";
                break;

            case 23:
                FishMozi.text = "‚Ê";
                break;

            case 24:
                FishMozi.text = "‚Ë";
                break;

            case 25:
                FishMozi.text = "‚Ì";
                break;

            case 26:
                FishMozi.text = "‚Í";
                break;

            case 27:
                FishMozi.text = "‚Ð";
                break;

            case 28:
                FishMozi.text = "‚Ó";
                break;

            case 29:
                FishMozi.text = "‚Ö";
                break;

            case 30:
                FishMozi.text = "‚Ù";
                break;

            case 31:
                FishMozi.text = "‚Ü";
                break;

            case 32:
                FishMozi.text = "‚Ý";
                break;

            case 33:
                FishMozi.text = "‚Þ";
                break;

            case 34:
                FishMozi.text = "‚ß";
                break;

            case 35:
                FishMozi.text = "‚à";
                break;

            case 36:
                FishMozi.text = "‚â";
                break;

            case 37:
                FishMozi.text = "‚ä";
                break;

            case 38:
                FishMozi.text = "‚æ";
                break;

            case 39:
                FishMozi.text = "‚ç";
                break;

            case 40:
                FishMozi.text = "‚è";
                break;

            case 41:
                FishMozi.text = "‚é";
                break;

            case 42:
                FishMozi.text = "‚ê";
                break;

            case 43:
                FishMozi.text = "‚ë";
                break;

            case 44:
                FishMozi.text = "‚í";
                break;

            case 45:
                FishMozi.text = "‚ð";
                break;

            case 46:
                FishMozi.text = "‚ñ";
                break;
        }
    }
}
