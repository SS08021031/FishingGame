using UnityEngine;

public class MapScroll : MonoBehaviour
{
    public float ScrollSpeed;
    //�X�N���[���̃X�s�[�h
    
    void Update()
    {
        transform.Translate(ScrollSpeed * Time.deltaTime, 0, 0);
        //�X�N���[���X�s�[�h�~���ԁ@�E�ɐi��

        if(transform.position.x > 36f)
        //�|�W�V������X�l��36���傫���Ȃ�����
        {
            transform.position = new Vector3(0, 0, 0);
            //���Ƃ̏ꏊ�ɖ߂�
        }
    }
}
