using System;
using UnityEngine;

namespace UnityEngine.Networking.Types
{

public enum NetworkAccessLevel : ulong
{
    Invalid = 0,
    User = 1,
    Owner = 2,
    Admin = 4,
}

}
