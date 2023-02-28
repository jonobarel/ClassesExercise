using System;

namespace ZeroPrep.ClassesDemo
{
    public class Player : Entity
    {
        public Weapon equippedWeapon;
        
        public override AttackResult Attack(Entity target)
        {
            if (equippedWeapon != null && SqrDistanceToTarget(target) < equippedWeapon.SqrRange())
            {
                return target.TakeDamage(GetAttackInfo());
            }
            else
            {
                return AttackResult.TargetOutOfRange;
            }
        }

        public Player()
        {
            Hp = 10;
        }
        public void SetWeapon(Weapon weapon)
        {
            equippedWeapon = weapon;
        }

        public override AttackInfo GetAttackInfo()
        {
            if (equippedWeapon != null)
            {
                return equippedWeapon.GetAttackInfo();
            }

            throw new ArgumentNullException("Weapon is not equipped");
        }
        
    }
}