using System;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public sealed class EventDispatcher
{
    public struct Gate : IDisposable
    {
        public Gate(Experimental.UIElements.EventDispatcher d);

        public void Dispose();

    }

}

}
