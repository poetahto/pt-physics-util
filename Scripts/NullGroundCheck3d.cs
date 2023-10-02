using pt_player_3d.Scripts;

namespace Plugins.pt_physics_util.Scripts
{
    public class NullGroundCheck3d : GroundCheck3d
    {
        public override bool IsGrounded => false;

        public override bool TryGetGround(out GroundData3d groundData3d)
        {
            groundData3d = default;
            return false;
        }
    }
}
