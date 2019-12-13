using System;
using UnityEngine;

namespace UnityEngine.Networking.PlayerConnection
{

public interface IConnectionState : IDisposable
{
    public Networking.PlayerConnection.ConnectionTarget connectedToTarget { get; }
    public string connectionName { get; }

}

}
