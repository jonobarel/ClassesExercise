namespace ZeroPrep.ClassesDemo
{
    public class Sword : Weapon
    {
        public Sword()
        {
            Damage = 3;
            Range = 1;
            WeaponType = Type.Melee;
            WeaponDamageType = DamageType.Normal;
        }
    }
}