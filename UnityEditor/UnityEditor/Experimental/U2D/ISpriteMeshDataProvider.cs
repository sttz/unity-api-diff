using System;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ISpriteMeshDataProvider
{
    public Vector2Int[] GetEdges(UnityEditor.GUID guid);
    public int[] GetIndices(UnityEditor.GUID guid);
    public UnityEditor.Experimental.U2D.Vertex2DMetaData[] GetVertices(UnityEditor.GUID guid);
    public void SetEdges(UnityEditor.GUID guid, Vector2Int[] edges);
    public void SetIndices(UnityEditor.GUID guid, int[] indices);
    public void SetVertices(UnityEditor.GUID guid, UnityEditor.Experimental.U2D.Vertex2DMetaData[] vertices);

}

}
