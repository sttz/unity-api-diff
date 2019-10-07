using System;
using UnityEngine;

namespace UnityEngine.Experimental.Networking.PlayerConnection
{

public interface IConnectionState : IDisposable
{
    public Experimental.Networking.PlayerConnection.ConnectionTarget connectedToTarget { get; }
    public string connectionName { get; }

}

}
