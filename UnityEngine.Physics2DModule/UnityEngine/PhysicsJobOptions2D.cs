using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace UnityEngine
{

public struct PhysicsJobOptions2D
{
    public int clearBodyForcesPerJob { get; set; }
    public int clearFlagsPerJob { get; set; }
    public int collideContactsPerJob { get; set; }
    public int findNearestContactsPerJob { get; set; }
    public int interpolationPosesPerJob { get; set; }
    public int islandSolverBodiesPerJob { get; set; }
    public int islandSolverBodyCostScale { get; set; }
    public int islandSolverContactCostScale { get; set; }
    public int islandSolverContactsPerJob { get; set; }
    public int islandSolverCostThreshold { get; set; }
    public int islandSolverJointCostScale { get; set; }
    public int newContactsPerJob { get; set; }
    public int syncContinuousFixturesPerJob { get; set; }
    public int syncDiscreteFixturesPerJob { get; set; }
    public int updateTriggerContactsPerJob { get; set; }
    public bool useConsistencySorting { get; set; }
    public bool useMultithreading { get; set; }

}

}
