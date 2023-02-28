namespace ZeroPrep.ClassesDemo
{
    public abstract class Weapon : IInventoryItem
    {
        public enum Type {Ranged, Melee}

        public enum DamageType
        {
            Normal,
            Fire,
            Magic
        }

        public int Damage;
        public int Range;
        public Type WeaponType;
        public DamageType WeaponDamageType;

        public virtual AttackInfo GetAttackInfo()
        {
            AttackInfo attack = new AttackInfo
            {
                Damage = Damage,
                AttackType = WeaponType,
                DamageType = WeaponDamageType
            };

            return attack;
        }
        
        public float SqrRange()
        {
            return Range * Range;
        }
        public virtual void Scrap()
        {
            //unequip weapon
        }

        public virtual float Value()
        {
            return 1;
        }
    }
}