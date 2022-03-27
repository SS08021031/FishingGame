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

//�e�L�X�g�����̉摜�̏�ɕ\�������悤�ɂ��Ă���
//New Vectoe3(?, ?, ?)�E�E�E�H�̕����̐�����ς���΁A�\������ʒu��ς�����
