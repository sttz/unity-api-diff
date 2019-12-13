using System;
using UnityEngine;

namespace UnityEditor.Experimental.GraphView
{

public interface IResizable
{
    public void OnResized();
    public void OnStartResize();

}

}
