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
                thema.text = "��";
                break;
            //�@1���o����A�e�L�X�g�Ɂu��v�����@

            case 2:
                thema.text = "��";
                break;
        }
    }
}
