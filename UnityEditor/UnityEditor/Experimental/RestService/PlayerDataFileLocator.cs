using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.RestService
{

public class PlayerDataFileLocator
{
    static public void Register(Locator locator);

    public PlayerDataFileLocator();

    public delegate bool Locator(string path);

}

}
