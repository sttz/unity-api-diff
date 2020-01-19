using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.UIElements
{

public interface IDataWatchHandle : IDisposable
{
    public bool disposed { get; }
    public Object watched { get; }

}

}
