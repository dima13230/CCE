using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleRotateButton : MonoBehaviour {

    public bool ForwardArrow;

    public BigCircle circle;

    private void OnMouseDown()
    {
        if (ForwardArrow) circle.RotateForward();
        else circle.RotateBackward();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
