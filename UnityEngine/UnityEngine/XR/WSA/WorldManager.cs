using System;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public class WorldManager
{
    static public XR.WSA.PositionalLocatorState state { get; }

    static public event OnPositionalLocatorStateChangedDelegate OnPositionalLocatorStateChanged;

    static public IntPtr GetNativeISpatialCoordinateSystemPtr();

    public WorldManager();

    public delegate void OnPositionalLocatorStateChangedDelegate(XR.WSA.PositionalLocatorState oldState, XR.WSA.PositionalLocatorState newState);

}

}
