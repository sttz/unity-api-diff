using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor
{

public class UndoSnapshot
{
    public UndoSnapshot(Object[] objectsToUndo);

    public void Dispose();
    public void Restore();

}

}
