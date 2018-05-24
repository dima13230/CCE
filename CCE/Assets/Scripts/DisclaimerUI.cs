using UnityEngine;
using System.Runtime.InteropServices;

public class DisclaimerUI : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OpenChalkoSite()
    {
        Debug.Log("Site open request...");
#if !UNITY_EDITOR
        if (Application.platform == RuntimePlatform.WebGLPlayer)
            openWindow("http://thiaoouba.com/aura_eye_exercise.htm");
        else Application.OpenURL("http://thiaoouba.com/aura_eye_exercise.htm");
#endif
    }

    [DllImport("__Internal")]
    private static extern void openWindow(string url);

}
