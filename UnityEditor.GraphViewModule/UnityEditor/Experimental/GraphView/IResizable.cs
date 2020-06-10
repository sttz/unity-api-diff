using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface IResizable
{
    public void OnResized();
    public void OnStartResize();

}

}
