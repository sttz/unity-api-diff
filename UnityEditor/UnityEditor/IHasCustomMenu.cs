using System;
using UnityEngine;

namespace UnityEditor
{

public interface IHasCustomMenu
{
    public void AddItemsToMenu(UnityEditor.GenericMenu menu);

}

}
