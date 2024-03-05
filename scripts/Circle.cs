using System.Collections;
using System.Collections.Generic;
using Godot;

public partial class Circle : TextureRect {

    int currentIndex = 0;

    public int m_CurrentIndex = 0;

    CirclesGroup bigCircle;

    public int CurrentIndex
    {
        get
        {
            return currentIndex;
        }
        set
        {
            currentIndex = value;
            Modulate = bigCircle.Colors[value];
        }
    }

    [Export]
    public int startIndex = 0;

    // Use this for initialization
    public override void _Ready()
    {
        base._Ready();
        bigCircle = GetParent() as CirclesGroup;
        CurrentIndex = startIndex;
    }

    public override void _Process(double delta)
    {
        base._Process(delta);
        m_CurrentIndex = currentIndex;
    }


    public void PlusIndex()
    {
        if (CurrentIndex == bigCircle.Colors.Length - 1) { CurrentIndex = 0; } else CurrentIndex++;
    }

    public void MinusIndex()
    {
        if (CurrentIndex == 0) { CurrentIndex = bigCircle.Colors.Length - 1; } else CurrentIndex--;
    }

}
