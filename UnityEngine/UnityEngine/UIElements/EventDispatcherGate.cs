using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public struct EventDispatcherGate : IDisposable, IEquatable<UIElements.EventDispatcherGate>
{
    public EventDispatcherGate(UIElements.EventDispatcher d);

    public void Dispose();
    public bool Equals(UIElements.EventDispatcherGate other);
    public bool Equals(object obj);
    public int GetHashCode();

}

}
