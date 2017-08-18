using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MinValueModifier : ValueModifier {
    public float _min;
    public MinValueModifier(int sortOrder,float min) : base(sortOrder)
    {
        _min = min;
    }
    public override float Modify(float value)
    {
        return Mathf.Min(_min, value);
    }
}
