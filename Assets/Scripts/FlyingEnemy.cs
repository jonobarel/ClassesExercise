using System;
using UnityEngine;
using Random = UnityEngine.Random;

namespace ZeroPrep.ClassesDemo
{
    /// <summary>
    /// FlyingEnemy - can only be hit by ranged attacks
    /// </summary>
    public class FlyingEnemy : Enemy
    {
        public int Range;
        
        public override void Move()
        {
            for (int i=0; i< 1000; i++)
            {
                Vector2Int newPosition = new Vector2Int(Random.Range(0, 10), Random.Range(0, 10));
                if (newPosition != Player.position)
                {
                    position = newPosition;
                    return;
                } 
            }
            Console.WriteLine("FlyingEnemy could not find new position to go to");
        }

        public override Entity.AttackResult TakeDamage(AttackInfo attackInfo)
        {
            if (attackInfo.AttackType != Weapon.Type.Ranged)
            {
                return AttackResult.TargetDodged;
            }

            return base.TakeDamage(attackInfo);
        }

        public FlyingEnemy(Player player) : base(player)
        {
            
        }

        protected override Player FindTarget()
        {
            return Player;
        }

        public override bool IsInRange(Entity e)
        {
            return true;
        }

        public override AttackInfo GetAttackInfo()
        {
            return new AttackInfo
            {
                Damage = 1,
                AttackType = Weapon.Type.Ranged,
                DamageType = Weapon.DamageType.Normal
            };
        }
    }
}