using System;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MeshGenerationContext
{
    public UIElements.VisualElement visualElement { get; }

    public UIElements.MeshWriteData Allocate(int vertexCount, int indexCount, Texture texture = null);

}

}
