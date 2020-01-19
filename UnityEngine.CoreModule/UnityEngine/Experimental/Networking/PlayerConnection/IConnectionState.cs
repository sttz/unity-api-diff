using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Networking.PlayerConnection
{

public interface IConnectionState : IDisposable
{
    public Experimental.Networking.PlayerConnection.ConnectionTarget connectedToTarget { get; }
    public string connectionName { get; }

}

}
