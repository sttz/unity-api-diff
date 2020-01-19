using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA.Input
{

public struct InteractionSource : IEquatable<XR.WSA.Input.InteractionSource>
{
    public XR.WSA.Input.InteractionSourceHandedness handedness { get; }
    public uint id { get; }
    public XR.WSA.Input.InteractionSourceKind kind { get; }
    public ushort productId { get; }
    public ushort productVersion { get; }
    public bool supportsGrasp { get; }
    public bool supportsMenu { get; }
    public bool supportsPointing { get; }
    public bool supportsThumbstick { get; }
    public bool supportsTouchpad { get; }
    public ushort vendorId { get; }

    public bool Equals(object obj);
    public bool Equals(XR.WSA.Input.InteractionSource other);
    public int GetHashCode();

}

}
