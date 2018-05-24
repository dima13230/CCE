using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MenuUI : MonoBehaviour {

    public bool QuitUnavailableOnWeb;
    public Button QuitButton;

	// Use this for initialization
	void Start () {
		if(QuitUnavailableOnWeb && Application.platform == RuntimePlatform.WebGLPlayer)
        {
            QuitButton.gameObject.SetActive(false);
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Quit()
    {
        Application.Quit();
    }
}
