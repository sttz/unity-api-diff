using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public sealed class Menu
{
    static public bool GetChecked(string menuPath);
    static public bool GetEnabled(string menuPath);
    static public void SetChecked(string menuPath, bool isChecked);

    public Menu();

}

}
