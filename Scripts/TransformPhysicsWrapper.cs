using poetools.Core.Abstraction;
using UnityEngine;

namespace Plugins.pt_physics_util.Scripts
{
    public class TransformPhysicsWrapper : PhysicsComponent
    {
        public override Vector3 Velocity { get; set; }

        private void Update()
        {
            transform.position += Velocity * Time.deltaTime;
        }
    }
}
