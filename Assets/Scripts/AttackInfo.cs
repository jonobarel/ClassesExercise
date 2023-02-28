namespace ZeroPrep.ClassesDemo
{
    public struct AttackInfo
    {
        public int Damage;
        public AttackType TypeOfAttack;
        public DamageType TypeOfDamage;
    }

    public enum AttackResult
    {
        AttackHit,
        AttackResisted,
        AttackMissed,
        AttackOutOfRange
    }
    
    public enum DamageType
    {
        Normal,
        Fire,
        Magic
    }
    
    public enum AttackType {Ranged, Melee, Magical}
}