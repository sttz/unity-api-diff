using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Rendering
{

public struct StencilState : IEquatable<Rendering.StencilState>
{
    static public Rendering.StencilState defaultValue { get; }

    public Rendering.CompareFunction compareFunctionBack { get; set; }
    public Rendering.CompareFunction compareFunctionFront { get; set; }
    public bool enabled { get; set; }
    public Rendering.StencilOp failOperationBack { get; set; }
    public Rendering.StencilOp failOperationFront { get; set; }
    public Rendering.StencilOp passOperationBack { get; set; }
    public Rendering.StencilOp passOperationFront { get; set; }
    public byte readMask { get; set; }
    public byte writeMask { get; set; }
    public Rendering.StencilOp zFailOperationBack { get; set; }
    public Rendering.StencilOp zFailOperationFront { get; set; }

    public StencilState(bool enabled = true, byte readMask = 255, byte writeMask = 255, Rendering.CompareFunction compareFunction = 8, Rendering.StencilOp passOperation = 0, Rendering.StencilOp failOperation = 0, Rendering.StencilOp zFailOperation = 0);
    public StencilState(bool enabled, byte readMask, byte writeMask, Rendering.CompareFunction compareFunctionFront, Rendering.StencilOp passOperationFront, Rendering.StencilOp failOperationFront, Rendering.StencilOp zFailOperationFront, Rendering.CompareFunction compareFunctionBack, Rendering.StencilOp passOperationBack, Rendering.StencilOp failOperationBack, Rendering.StencilOp zFailOperationBack);

    public bool Equals(object obj);
    public bool Equals(Rendering.StencilState other);
    public int GetHashCode();
    public void SetCompareFunction(Rendering.CompareFunction value);
    public void SetFailOperation(Rendering.StencilOp value);
    public void SetPassOperation(Rendering.StencilOp value);
    public void SetZFailOperation(Rendering.StencilOp value);

}

}
