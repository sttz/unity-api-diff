using System;
using UnityEngine;

namespace UnityEditor.Localization.Editor
{

public sealed class LocalizationAttribute : Attribute
{
    public LocalizationAttribute(string locGroupName = null);

}

}
