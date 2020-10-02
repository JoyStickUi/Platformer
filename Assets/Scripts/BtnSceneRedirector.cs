using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BtnSceneRedirector : MonoBehaviour
{

	[Header("Сцена")]
	public string scene;
	public Button btn;

	void Start(){
		btn.onClick.AddListener(OnClick);
	}

    void OnClick(){
        
    	SceneManager.LoadScene(scene);

    }
}
