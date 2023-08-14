using UnityEngine;

namespace poetools.Core.Abstraction
{
    public interface IPhysicsComponent
    {
        Vector3 Velocity { get; set; }
    }

    public abstract class PhysicsComponent : MonoBehaviour, IPhysicsComponent
    {
        public abstract Vector3 Velocity { get; set; }
    }
}