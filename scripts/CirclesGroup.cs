using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using Godot;

public partial class CirclesGroup : Control {

    [Export]
    public Color[] Colors;

    public int CirclesSeparation
    {
        get
        {
            return GetThemeConstant("separation");
        }
        set
        {
            AddThemeConstantOverride("separation", value);
        }
    }

    public void RotateBackward()
    {
        Circle[] circles = NeitriExtensions.FindChildrenOfType<Circle>(this).ToArray();
        foreach (Circle circle in circles) circle.PlusIndex();
    }

    public void RotateForward()
    {
        Circle[] circles = NeitriExtensions.FindChildrenOfType<Circle>(this).ToArray();
        foreach (Circle circle in circles) circle.MinusIndex();
    }

    public void ModifyCirclesSeparation(float value)
    {
        CirclesSeparation = (int)value;
    }
}
