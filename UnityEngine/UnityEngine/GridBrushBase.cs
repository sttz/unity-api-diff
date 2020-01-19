using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public abstract class GridBrushBase : ScriptableObject
{
    protected GridBrushBase();

    public void BoxErase(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void BoxFill(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void ChangeZPosition(int change);
    public void Erase(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void Flip(FlipAxis flip, CellLayout layout);
    public void FloodFill(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void Move(GridLayout gridLayout, GameObject brushTarget, BoundsInt from, BoundsInt to);
    public void MoveEnd(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void MoveStart(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);
    public void Paint(GridLayout gridLayout, GameObject brushTarget, Vector3Int position);
    public void Pick(GridLayout gridLayout, GameObject brushTarget, BoundsInt position, Vector3Int pivot);
    public void ResetZPosition();
    public void Rotate(RotationDirection direction, CellLayout layout);
    public void Select(GridLayout gridLayout, GameObject brushTarget, BoundsInt position);

    public enum FlipAxis
    {
        X = 0,
        Y = 1,
    }

    public enum RotationDirection
    {
        Clockwise = 0,
        CounterClockwise = 1,
    }

    public enum Tool
    {
        Select = 0,
        Move = 1,
        Paint = 2,
        Box = 3,
        Pick = 4,
        Erase = 5,
        FloodFill = 6,
    }

}

}
