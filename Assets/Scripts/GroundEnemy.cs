using System;
using Unity.VisualScripting;

namespace ZeroPrep.ClassesDemo
{
    public class GroundEnemy : Enemy
    {
        public GroundEnemy(Player player) : base(player)
        {
        }

        public override AttackInfo GetAttackInfo()
        {
            return new AttackInfo
            {
                Damage = 3,
                DamageType = Weapon.DamageType.Fire,
                AttackType = Weapon.Type.Melee
            };
        }

        public override void Move()
        {
            int x_dist = Player.position.x - position.x;
            int y_dist = Player.position.y - position.y;

            if (Math.Abs(x_dist) > Math.Abs(y_dist) && Math.Abs(x_dist) > 1)
            {
                position.x += Math.Sign(x_dist);
            }
            else if (Math.Abs(y_dist) >= Math.Abs(x_dist) && Math.Abs(y_dist) > 1)
            {
                position.y += Math.Sign(y_dist);
            }
        }

        protected override Player FindTarget()
        {
            if (IsInRange(Player))
            {
                return Player;
            }

            return null;
        }
    }
}