using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetLevel : MonoBehaviour {

    public Transform CurrentLevelParent;

    public Transform Level;

    public bool AnyKeyToPerform;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		//if(Input.anyKeyDown && AnyKeyToPerform)
        //{
        //    SetLevelMethod();
        //}
	}

    public void SetLevelMethod()
    {
        Level.gameObject.SetActive(true);
        CurrentLevelParent.gameObject.SetActive(false);
    }

    private void OnMouseDown()
    {
        Level.gameObject.SetActive(true);
        transform.parent.gameObject.SetActive(false);
    }
}
