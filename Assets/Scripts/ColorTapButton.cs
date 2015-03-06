﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public enum TapColor
{
    Red,
    Green,
    Blue,
    Magenta,
    Yellow,
    Cyan
}

public enum TapType
{
    Full,
    Half
}

public class ColorTapButton : Button
{

    public TapColor TColor;
    public TapType TType;

	void OnDisable()
    {
        animator.enabled = false;
        image.enabled = false;
    }

    void OnEnable()
    {
        animator.enabled = true;
        image.enabled = true;
    }
}
