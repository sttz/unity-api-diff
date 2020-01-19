using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public sealed class ComponentUtility
{
    static public bool CopyComponent(Component component);
    static public void DestroyComponentsMatching(GameObject dst, IsDesiredComponent componentFilter);
    static public bool MoveComponentDown(Component component);
    static public bool MoveComponentUp(Component component);
    static public bool PasteComponentAsNew(GameObject go);
    static public bool PasteComponentValues(Component component);
    static public void ReplaceComponentsIfDifferent(GameObject src, GameObject dst, IsDesiredComponent componentFilter);

    public ComponentUtility();

    public delegate bool IsDesiredComponent(Component c);

}

}
