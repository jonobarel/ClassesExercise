namespace ZeroPrep.ClassesDemo
{
    public interface IDamageable
    {
        public Entity.AttackResult TakeDamage(AttackInfo attackInfo);
    }
}