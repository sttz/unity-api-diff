using System;
using UnityEngine;

namespace UnityEditor
{

public sealed class Menu
{
    static public bool GetChecked(string menuPath);
    static public void SetChecked(string menuPath, bool isChecked);

    public Menu();

}

}
