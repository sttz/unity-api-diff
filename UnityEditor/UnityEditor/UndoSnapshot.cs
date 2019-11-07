using System;
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
