using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class MenuCommand
{
    public Object context;
    public int userData;

    public MenuCommand(Object inContext, int inUserData);
    public MenuCommand(Object inContext);

}

}
