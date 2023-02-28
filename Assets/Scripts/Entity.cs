using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZeroPrep.ClassesDemo
{
    public abstract class Entity : IDamageable
    {
        public enum AttackResult
        {
            TargetHit,
            TargetOutOfRange,
            TargetDestroyed,
            TargetDodged
            
        }
       
        public float Hp = 3;
        public bool isAlive = true;
        public Vector2Int position;

        public abstract AttackInfo GetAttackInfo();
        
        public abstract AttackResult Attack(Entity target);

        public float SqrDistanceToTarget(Entity target)
        {
            return (position - target.position).sqrMagnitude;
        }
        
        // NOTE TO SELF - start with "simple" damage (int only) before building the struct
        public virtual AttackResult TakeDamage( AttackInfo attackInfo)
        {
            Hp -= attackInfo.Damage;
            if (Hp < 0)
            {
                Die();
                return AttackResult.TargetDestroyed;
            }

            return AttackResult.TargetHit;
        }

        public virtual void Die()
        {
            isAlive = false;
        }

    }
}