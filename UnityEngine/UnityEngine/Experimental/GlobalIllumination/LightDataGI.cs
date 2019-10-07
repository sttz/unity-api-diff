using System;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct LightDataGI
{
    public Experimental.GlobalIllumination.LinearColor color;
    public float coneAngle;
    public Experimental.GlobalIllumination.FalloffType falloff;
    public Experimental.GlobalIllumination.LinearColor indirectColor;
    public float innerConeAngle;
    public int instanceID;
    public Experimental.GlobalIllumination.LightMode mode;
    public Quaternion orientation;
    public Vector3 position;
    public float range;
    public byte shadow;
    public float shape0;
    public float shape1;
    public Experimental.GlobalIllumination.LightType type;

    public void Init(Experimental.GlobalIllumination.DirectionalLight light);
    public void Init(Experimental.GlobalIllumination.PointLight light);
    public void Init(Experimental.GlobalIllumination.SpotLight light);
    public void Init(Experimental.GlobalIllumination.RectangleLight light);
    public void Init(Experimental.GlobalIllumination.DiscLight light);
    public void Init(Experimental.GlobalIllumination.SpotLightBoxShape light);
    public void Init(Experimental.GlobalIllumination.SpotLightPyramidShape light);
    public void InitNoBake(int lightInstanceID);

}

}
