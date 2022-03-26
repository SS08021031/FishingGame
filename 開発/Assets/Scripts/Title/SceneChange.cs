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
	    //Aキーを押したら
        {
			isScene = true;
			//isSceneがtrueになる
		}


		if (isScene)
		//isSceneがtrueになったら
		{
			Invoke("Next", 3.0f);
			//3秒後に”Next”の処理が開始
		}
	}

	void Next()
	{
		SceneManager.LoadScene("InGameScene");
		//インゲームシーンに移行
	}
}
