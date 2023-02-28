namespace ZeroPrep.ClassesDemo
{
    public abstract class Weapon    {

        
        public int Damage;
        public int Range;
        public AttackType WeaponType;
        public DamageType WeaponDamageType;

        public virtual AttackInfo GetAttackInfo()
        {
            AttackInfo attack = new AttackInfo
            {
                Damage = Damage,
                TypeOfAttack = WeaponType,
                TypeOfDamage = WeaponDamageType
            };

            return attack;
        }
        
        public virtual float SqrRange()
        {
            return Range * Range;
        }

        public virtual float Value()
        {
            return 1;
        }
    }
}