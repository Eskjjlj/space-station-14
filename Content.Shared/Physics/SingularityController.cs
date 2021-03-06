#nullable enable
using Robust.Shared.GameObjects;
using Robust.Shared.Maths;
using Robust.Shared.Physics;

namespace Content.Shared.Physics
{
    public class SingularityController : VirtualController
    {
        public override IPhysicsComponent? ControlledComponent { protected get; set; }


        public void Push(Vector2 velocityDirection, float speed)
        {
            LinearVelocity = velocityDirection * speed;
        }
    }
}
