using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class LightingExplorerExtensionAttribute : Attribute
{
    public LightingExplorerExtensionAttribute(Type renderPipeline);

}

}
