using System;
using UnityEngine;

namespace UnityEngine.Networking.PlayerConnection
{

public class PlayerConnection : ScriptableObject, Networking.PlayerConnection.IEditorPlayerConnection
{
    static public Networking.PlayerConnection.PlayerConnection instance { get; }

    public bool isConnected { get; }

    public PlayerConnection();

    public bool BlockUntilRecvMsg(Guid messageId, int timeout);
    public void DisconnectAll();
    public void OnEnable();
    public void Register(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);
    public void RegisterConnection(Events.UnityAction<int> callback);
    public void RegisterDisconnection(Events.UnityAction<int> callback);
    public void Send(Guid messageId, byte[] data);
    public void Unregister(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);

}

}
