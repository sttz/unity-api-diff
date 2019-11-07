using System;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class DidReloadScripts : UnityEditor.CallbackOrderAttribute
{
    public DidReloadScripts();
    public DidReloadScripts(int callbackOrder);

}

}
