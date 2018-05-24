using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmallCircle : MonoBehaviour {

    int currentIndex = 0;

    public int m_CurrentIndex = 0;

    BigCircle bigCircle;

    public int CurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            currentIndex = value;
            GetComponent<SpriteRenderer>().color = bigCircle.Colors[value];
        }
    }

    public int startIndex = 0;

	// Use this for initialization
	void Start () {
        bigCircle = transform.parent.GetComponent<BigCircle>();
        CurrentIndex = startIndex;
	}

    private void Update()
    {
        m_CurrentIndex = currentIndex;
    }

    public void PlusIndex()
    {
        if (CurrentIndex + 1 == 6) { CurrentIndex = 0; } else CurrentIndex++;
    }

    public void MinusIndex()
    {
        if (CurrentIndex - 1 == -1) { CurrentIndex = 5; } else CurrentIndex--;
    }

}
