using UnityEngine;

namespace poetools.Core.Abstraction.Unity
{
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerWrapper : PhysicsComponent
    {
        private CharacterController _character;
        
        private void Awake()
        {
            _character = GetComponent<CharacterController>();
        }

        private void Update()
        {
            _character.Move(Velocity * Time.deltaTime);

            if (Mathf.Round(_character.velocity.sqrMagnitude) < Mathf.Round(Velocity.sqrMagnitude))
                Velocity = _character.velocity;
        }
        
        public override Vector3 Velocity { get; set; }
    }
}