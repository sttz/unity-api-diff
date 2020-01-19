using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.Rendering
{

public class RenderPass : IDisposable
{
    public Experimental.Rendering.RenderPassAttachment[] colorAttachments { get; private set; }
    public Experimental.Rendering.ScriptableRenderContext context { get; private set; }
    public Experimental.Rendering.RenderPassAttachment depthAttachment { get; private set; }
    public int height { get; private set; }
    public int sampleCount { get; private set; }
    public int width { get; private set; }

    public RenderPass(Experimental.Rendering.ScriptableRenderContext ctx, int w, int h, int samples, Experimental.Rendering.RenderPassAttachment[] colors, Experimental.Rendering.RenderPassAttachment depth = null);

    public void Dispose();

    public class SubPass : IDisposable
    {
        public SubPass(Experimental.Rendering.RenderPass renderPass, Experimental.Rendering.RenderPassAttachment[] colors, Experimental.Rendering.RenderPassAttachment[] inputs, bool readOnlyDepth = false);

        public void Dispose();

    }

}

}
