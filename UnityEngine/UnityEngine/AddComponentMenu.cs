using System;
using UnityEngine;

namespace UnityEngine
{

public sealed class AddComponentMenu : Attribute
{
    public string componentMenu { get; }
    public int componentOrder { get; }

    public AddComponentMenu(string menuName);
    public AddComponentMenu(string menuName, int order);

}

}