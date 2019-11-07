using System;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IOrderedCallback
{
    public int callbackOrder { get; }

}

}
