using System;
using UnityEngine;

namespace UnityEngine.Networking
{

public enum NetworkError
{
    Ok = 0,
    WrongHost = 1,
    WrongConnection = 2,
    WrongChannel = 3,
    NoResources = 4,
    BadMessage = 5,
    Timeout = 6,
    MessageToLong = 7,
    WrongOperation = 8,
    VersionMismatch = 9,
    CRCMismatch = 10,
    DNSFailure = 11,
    UsageError = 12,
}

}
