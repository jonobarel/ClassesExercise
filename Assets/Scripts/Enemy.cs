namespace ZeroPrep.ClassesDemo
{
    public abstract class Enemy : Entity
    {
        public Player Player;
        protected abstract Player FindTarget();
        public abstract void Move();
        
        public Enemy(Player player)
        {
            Player = player;
        }

        public override AttackResult Attack(Entity target)
        {
            if (IsInRange(target))
            {
                return target.TakeDamage(GetAttackInfo());
            }

            return AttackResult.TargetOutOfRange;
        }
        
        public virtual void DoActions()
        {
            Player target = FindTarget();

            if (target != null)
            {
                Attack(target);
            }

            Move();
        }

        public virtual bool IsInRange(Entity e)
        {
            return SqrDistanceToTarget(e) <= 1f;
        }
    }
}