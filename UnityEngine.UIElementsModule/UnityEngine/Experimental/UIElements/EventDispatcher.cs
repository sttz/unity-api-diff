using System;
using System.Collections;
using System.Collections.Generic;
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
