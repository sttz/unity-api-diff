using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements.Experimental
{

public interface IValueAnimation
{
    public int durationMs { get; set; }
    public bool isRunning { get; }

    public void Recycle();
    public void Start();
    public void Stop();

}

}
