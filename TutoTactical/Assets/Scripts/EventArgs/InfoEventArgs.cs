using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class InfoEventArgs<T> : EventArgs {
    public T info;
    public InfoEventArgs()
    {
        info = default(T);
    }
    public InfoEventArgs(T minfo)
    {
        info = minfo;
    }
}
