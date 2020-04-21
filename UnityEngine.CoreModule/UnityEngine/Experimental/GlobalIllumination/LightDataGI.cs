using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine.Experimental.GlobalIllumination
{

public struct LightDataGI
{
    public Experimental.GlobalIllumination.LinearColor color;
    public float coneAngle;
    public int cookieID;
    public float cookieScale;
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
    public void Init(Experimental.GlobalIllumination.DiscLight light);
    public void Init(Experimental.GlobalIllumination.PointLight light);
    public void Init(Experimental.GlobalIllumination.RectangleLight light);
    public void Init(Experimental.GlobalIllumination.SpotLight light);
    public void Init(Experimental.GlobalIllumination.SpotLightBoxShape light);
    public void Init(Experimental.GlobalIllumination.SpotLightPyramidShape light);
    public void Init(Experimental.GlobalIllumination.DirectionalLight light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.DiscLight light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.PointLight light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.RectangleLight light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.SpotLight light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.SpotLightBoxShape light, Experimental.GlobalIllumination.Cookie cookie);
    public void Init(Experimental.GlobalIllumination.SpotLightPyramidShape light, Experimental.GlobalIllumination.Cookie cookie);
    public void InitNoBake(int lightInstanceID);

}

}
