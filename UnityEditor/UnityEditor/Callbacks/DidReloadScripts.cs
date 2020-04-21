using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class DidReloadScripts : UnityEditor.CallbackOrderAttribute
{
    public DidReloadScripts();
    public DidReloadScripts(int callbackOrder);

}

}
