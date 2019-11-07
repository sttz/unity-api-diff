using System;
using UnityEngine;

namespace UnityEditor.Experimental.Networking.PlayerConnection
{

public static class EditorGUIUtility
{
    static public Experimental.Networking.PlayerConnection.IConnectionState GetAttachToPlayerState(UnityEditor.EditorWindow parentWindow, Action<string> connectedCallback = null);

}

}
