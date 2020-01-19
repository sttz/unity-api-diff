using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Localization.Editor
{

public class LocalizationGroup : IDisposable
{
    public string locGroupName { get; }

    public LocalizationGroup();
    public LocalizationGroup(Behaviour behaviour);
    public LocalizationGroup(object obj);
    public LocalizationGroup(Type type);

    public void Dispose();

}

}
