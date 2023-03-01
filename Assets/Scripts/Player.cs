using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Entity
{
    public enum WeaponType { Bow, Sword, None }

    public WeaponType equippedWeapon;
    
    public void Start()
    {
        Debug.Log($"Hi! I am {gameObject.name}, and I have {HP} hit points");
        equippedWeapon = WeaponType.Sword;
    }

    public override int Attack(Entity target)
    {
        int range = 0;
        int damage = 0;
        
        switch (equippedWeapon)
        {
            case(WeaponType.Sword):
                range = 1;
                damage = 3;
                break;
            case(WeaponType.Bow):
                range = 10;
                damage = 1;
                break;
            case(WeaponType.None):
                default:
                break;
        }

        Vector2Int distance = target.GridPosition - GridPosition;
        if (distance.magnitude <= range)
        {
            target.TakeDamage(damage);
            return damage;
        }

        return 0;


    }
}
