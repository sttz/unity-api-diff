using System;
using UnityEngine;

namespace UnityEngine.Networking.PlayerConnection
{

public interface IEditorPlayerConnection
{
    public void DisconnectAll();
    public void Register(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);
    public void RegisterConnection(Events.UnityAction<int> callback);
    public void RegisterDisconnection(Events.UnityAction<int> callback);
    public void Send(Guid messageId, byte[] data);
    public void Unregister(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);

}

}
