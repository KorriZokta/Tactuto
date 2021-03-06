﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddValueModifier : ValueModifier {

    public readonly float _toAdd;
    public AddValueModifier(int sortOrder,float toAdd) : base(sortOrder)
    {
        _toAdd = toAdd;
    }
    public override float Modify(float value)
    {
        return value + _toAdd;
    }
}
