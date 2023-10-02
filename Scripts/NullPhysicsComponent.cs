using poetools.Core.Abstraction;
using UnityEngine;

namespace Plugins.pt_physics_util.Scripts
{
    public class NullPhysicsComponent : PhysicsComponent
    {
        public override Vector3 Velocity { get; set; }
    }
}
