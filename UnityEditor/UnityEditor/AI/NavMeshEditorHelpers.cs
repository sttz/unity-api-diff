using System;
using UnityEngine;

namespace UnityEditor.AI
{

public static class NavMeshEditorHelpers
{
    static public void DrawAgentDiagram(Rect rect, float agentRadius, float agentHeight, float agentClimb, float agentSlope);
    static public void DrawBuildDebug(AI.NavMeshData navMeshData, AI.NavMeshBuildDebugFlags flags);
    static public void DrawBuildDebug(AI.NavMeshData navMeshData);
    static public void OpenAgentSettings(int agentTypeID);
    static public void OpenAreaSettings();

}

}
