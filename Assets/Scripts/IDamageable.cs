namespace ZeroPrep.ClassesDemo
{
    public interface IDamageable
    {
        /// <summary>
        /// the TakeDamage method is used by the IDamageable interface
        /// to receive damage from players, enemies, projectiles and enviornmental effects.
        /// </summary>
        /// <param name="attackInfo">AttackInfo defining the parameters of the attack, used by the
        /// game entity to determine the effect on it.</param>
        /// <returns>damage dealt</returns>
        public int TakeDamage(AttackInfo attackInfo);

        public bool IsAlive();
    }
}