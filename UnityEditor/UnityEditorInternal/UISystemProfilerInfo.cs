using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditorInternal
{

public struct UISystemProfilerInfo
{
    public UnityEditorInternal.BatchBreakingReason batchBreakingReason;
    public int batchCount;
    public int instanceIDsCount;
    public int instanceIDsIndex;
    public bool isBatch;
    public int objectInstanceId;
    public int objectNameOffset;
    public int parentId;
    public int renderDataCount;
    public int renderDataIndex;
    public int totalBatchCount;
    public int totalVertexCount;
    public int vertexCount;

}

}
