using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Networking.PlayerConnection
{

public class EditorConnection : UnityEditor.ScriptableSingleton<UnityEditor.Networking.PlayerConnection.EditorConnection>, Networking.PlayerConnection.IEditorPlayerConnection
{
    public List<UnityEditor.Networking.PlayerConnection.ConnectedPlayer> ConnectedPlayers { get; }

    public EditorConnection();

    public void DisconnectAll();
    public void Initialize();
    public void Register(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);
    public void RegisterConnection(Events.UnityAction<int> callback);
    public void RegisterDisconnection(Events.UnityAction<int> callback);
    public void Send(Guid messageId, byte[] data);
    public void Send(Guid messageId, byte[] data, int playerId);
    public bool TrySend(Guid messageId, byte[] data);
    public bool TrySend(Guid messageId, byte[] data, int playerId);
    public void Unregister(Guid messageId, Events.UnityAction<Networking.PlayerConnection.MessageEventArgs> callback);
    public void UnregisterConnection(Events.UnityAction<int> callback);
    public void UnregisterDisconnection(Events.UnityAction<int> callback);

}

}
