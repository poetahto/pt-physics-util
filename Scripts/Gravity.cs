using pt_player_3d.Scripts;
using UnityEngine;

namespace poetools.Core.Abstraction
{
    // todo: needs cleaning
    
    [RequireComponent(typeof(IPhysicsComponent))]
    public class Gravity : MonoBehaviour
    {
        [SerializeField]
        public Vector3 downDirection = Vector3.down;
        
        [SerializeField]
        public float amount = -Physics.gravity.y;
        
        [SerializeField]
        private float idleGravity;
        
        [SerializeField]
        public GroundCheck3d groundCheck;
        
        [SerializeField] 
        private bool autoUpdate = true;

        private IPhysicsComponent _physicsComponent;

        private void Awake()
        {
            _physicsComponent = GetComponent<IPhysicsComponent>();
        }

        private void FixedUpdate()
        {
            if (autoUpdate)
                Tick(Time.fixedDeltaTime);
        }

        public void Tick(float deltaTime)
        {
            _physicsComponent.Velocity = !groundCheck.IsGrounded || _physicsComponent.Velocity.y > 0
                ? _physicsComponent.Velocity + downDirection * (amount * deltaTime)
                : _physicsComponent.Velocity + Vector3.down * idleGravity;
        }
    }
}
