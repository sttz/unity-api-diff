using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.Networking.PlayerConnection
{

public static class EditorGUIUtility
{
    static public Experimental.Networking.PlayerConnection.IConnectionState GetAttachToPlayerState(UnityEditor.EditorWindow parentWindow, Action<string> connectedCallback = null);

}

}
