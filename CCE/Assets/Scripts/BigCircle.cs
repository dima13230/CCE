using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigCircle : MonoBehaviour {

    public Color[] Colors;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void RotateBackward()
    {
        SmallCircle[] circles = GetComponentsInChildren<SmallCircle>();
        foreach (SmallCircle circle in circles) circle.PlusIndex();
    }

    public void RotateForward()
    {
        SmallCircle[] circles = GetComponentsInChildren<SmallCircle>();
        foreach (SmallCircle circle in circles) circle.MinusIndex();
    }
}
