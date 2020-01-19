using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Build
{

public interface IOrderedCallback
{
    public int callbackOrder { get; }

}

}
