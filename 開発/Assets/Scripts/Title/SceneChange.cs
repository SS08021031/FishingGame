using UnityEngine;
using UnityEngine.SceneManagement;
public class SceneChange : MonoBehaviour
{
	public bool isScene;


void Start()
	{
		isScene = false;

	}

	void Update()
	{
		if(Input.GetKey(KeyCode.A))
	    //A�L�[����������
        {
			isScene = true;
			//isScene��true�ɂȂ�
		}


		if (isScene)
		//isScene��true�ɂȂ�����
		{
			Invoke("Next", 3.0f);
			//3�b��ɁhNext�h�̏������J�n
		}
	}

	void Next()
	{
		SceneManager.LoadScene("InGameScene");
		//�C���Q�[���V�[���Ɉڍs
	}
}
