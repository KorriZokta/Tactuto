using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseException {

	public bool toggle { get; private set; }
    private bool _defaultToggle;
    public BaseException(bool defaultToggle)
    {
        _defaultToggle = defaultToggle;
        toggle = defaultToggle;
    }
    public void FlipToggle()
    {
        toggle = !_defaultToggle;
    }
}
