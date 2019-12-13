using System;
using UnityEngine;

namespace UnityEditor.Networking.PlayerConnection
{

public static class PlayerConnectionGUIUtility
{
    static public Networking.PlayerConnection.IConnectionState GetConnectionState(UnityEditor.EditorWindow parentWindow, Action<string> connectedCallback = null);

}

}
