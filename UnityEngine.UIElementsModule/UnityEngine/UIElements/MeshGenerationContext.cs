using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.UIElements
{

public class MeshGenerationContext
{
    public UIElements.VisualElement visualElement { get; }

    public UIElements.MeshWriteData Allocate(int vertexCount, int indexCount, Texture texture = null);

}

}
