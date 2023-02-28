using UnityEngine;

namespace ZeroPrep.ClassesDemo
{
    public class PlayerController : EntityController
    {
        public new void Awake()
        {
            base.Awake();
            SetEntity();
        }
        public Player PlayerEntity()
        {
            return (Player)entity;
        }

        public void EquipWeapon(Weapon w)
        {
            PlayerEntity().equippedWeapon = w;
        }
        
        public override void SetEntity()
        {
            entity = new Player();
        }

        public void Attack(Enemy target)
        {
            PlayerEntity().Attack(target);
        }
        
        public void Move(Vector2Int dir)
        {
            entity.position+=dir;
        }

        
        
    }
}