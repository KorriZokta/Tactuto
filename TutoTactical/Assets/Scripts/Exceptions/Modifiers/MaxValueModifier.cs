using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaxValueModifier : ValueModifier {

    public float _max;
    public MaxValueModifier(int sortOrder,float max) : base(sortOrder)
    {
        _max = max;
    }
    public override float Modify(float value)
    {
        return Mathf.Max(value, _max);
    }
}
