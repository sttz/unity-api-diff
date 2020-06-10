using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class LocalizationAttribute : Attribute
{
    public LocalizationAttribute(string locGroupName = null);

}

}
