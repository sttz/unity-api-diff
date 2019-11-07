using System;
using UnityEngine;

namespace UnityEditor.Localization.Editor
{

public class LocalizationGroup : IDisposable
{
    public string locGroupName { get; }

    public LocalizationGroup();
    public LocalizationGroup(Behaviour behaviour);
    public LocalizationGroup(Type type);
    public LocalizationGroup(object obj);

    public void Dispose();

}

}
