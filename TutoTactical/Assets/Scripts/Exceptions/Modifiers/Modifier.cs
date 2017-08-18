using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Modifier {
    public readonly int _sortOrder;
    public Modifier(int sortOrder)
    {
        _sortOrder = sortOrder;
    }
}
