using System;
using UnityEngine;

namespace UnityEditor
{

public class LightingExplorerExtensionAttribute : Attribute
{
    public LightingExplorerExtensionAttribute(Type renderPipeline);

}

}
