
using UnityEngine;

public class RandomFish : MonoBehaviour
{
    public GameObject FishPrefabs;
    //���̂������������������

    public float X_min;�@//�w���̍ŏ��l
    public float X_max;�@//�w���̍ő�l

    public float Y_min;�@//�x���̍ŏ��l
    public float Y_max;�@//�x���̍ő�l

    public float count;�@//�����o��������
    void Start()
    {
        
    }

    void Update()
    {
        count++;

        if(count >= 5)
        {
            float x = Random.Range(X_min, X_max);�@//�w���̍ŏ��l�`�ő�l�܂ł̐��l�������_���ɏo��
            float y = Random.Range(Y_min, Y_max);�@//�x���̍ŏ��l�`�ő�l�܂ł̐��l�������_���ɏo��
            
            Vector2 pos = new Vector2(x, y);�@//�o���w���Ƃx���̐��l��V����Vector2�ɑ��

            Instantiate(FishPrefabs, pos, Quaternion.identity);�@//�V����Vector2�̏ꏊ�ɐ�������
        }
    }
}
