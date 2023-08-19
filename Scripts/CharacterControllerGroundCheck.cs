using System;
using pt_player_3d.Scripts;
using UnityEngine;

namespace DefaultNamespace
{
    [RequireComponent(typeof(CharacterController))]
    public class CharacterControllerGroundCheck : GroundCheck3d
    {
        private CharacterController _characterController;

        private void Awake()
        {
            _characterController = GetComponent<CharacterController>();
        }

        public override bool IsGrounded => _characterController.isGrounded;

        public override bool TryGetGround(out GroundData3d groundData3d)
        {
            groundData3d = default;
            return false;
        }
    }
}
