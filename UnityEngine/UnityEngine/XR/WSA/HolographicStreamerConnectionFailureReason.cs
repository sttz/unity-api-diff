using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.XR.WSA
{

public enum HolographicStreamerConnectionFailureReason
{
    None = 0,
    Unknown = 1,
    Unreachable = 2,
    HandshakeFailed = 3,
    ProtocolVersionMismatch = 4,
    ConnectionLost = 5,
}

}
