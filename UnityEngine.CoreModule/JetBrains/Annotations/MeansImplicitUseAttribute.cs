using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JetBrains.Annotations
{

public sealed class MeansImplicitUseAttribute : Attribute
{
    public JetBrains.Annotations.ImplicitUseTargetFlags TargetFlags { get; }
    public JetBrains.Annotations.ImplicitUseKindFlags UseKindFlags { get; }

    public MeansImplicitUseAttribute();
    public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);
    public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags);
    public MeansImplicitUseAttribute(JetBrains.Annotations.ImplicitUseKindFlags useKindFlags, JetBrains.Annotations.ImplicitUseTargetFlags targetFlags);

}

}
