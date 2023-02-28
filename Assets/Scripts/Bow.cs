namespace ZeroPrep.ClassesDemo
{
    public class Bow : Weapon
    {
        public Bow()
        {
            Damage = 1;
            WeaponType = Type.Ranged;
            WeaponDamageType = DamageType.Fire;
            Range = 20;
        }
    }
}