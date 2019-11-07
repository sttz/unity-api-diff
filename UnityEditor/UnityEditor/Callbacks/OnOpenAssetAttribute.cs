using System;
using UnityEngine;

namespace UnityEditor.Callbacks
{

public sealed class OnOpenAssetAttribute : UnityEditor.CallbackOrderAttribute
{
    public OnOpenAssetAttribute();
    public OnOpenAssetAttribute(int callbackOrder);

}

}
