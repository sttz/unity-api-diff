using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.Experimental.U2D
{

public interface ITextureDataProvider
{
    public Texture2D previewTexture { get; }
    public Texture2D texture { get; }

    public Texture2D GetReadableTexture2D();
    public void GetTextureActualWidthAndHeight(out int width, out int height);

}

}
