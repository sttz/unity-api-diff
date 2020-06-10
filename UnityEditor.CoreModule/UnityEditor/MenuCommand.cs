using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class MenuCommand
{
    public Object context;
    public int userData;

    public MenuCommand(Object inContext);
    public MenuCommand(Object inContext, int inUserData);

}

}
