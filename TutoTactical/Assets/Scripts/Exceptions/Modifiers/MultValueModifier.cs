using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultValueModifier : ValueModifier {
    public readonly float _toMultiply;
    public MultValueModifier(int sortOrder, float toMultiply) : base(sortOrder)
    {
        _toMultiply = toMultiply;
    }
    public override float Modify(float value)
    {
        return value * _toMultiply;
    }
}
