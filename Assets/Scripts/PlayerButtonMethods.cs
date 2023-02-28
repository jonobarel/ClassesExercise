using System;
using UnityEngine;

namespace ZeroPrep.ClassesDemo
{
    public class PlayerButtonMethods : MonoBehaviour
    {
        private PlayerController _playerController;
        public EnemyController flyingEnemy;
        public EnemyController groundedEnemy;
        

        public void Start()
        {
            _playerController = GetComponent<PlayerController>();
            EquipSword();
        }
        
        public void EquipSword()
        {
            _playerController.EquipWeapon(new Sword());
        }

        public void EquipBow()
        {
            _playerController.EquipWeapon(new Bow());
        }
        
        public void MoveN()
        {
            _playerController.Move(Vector2Int.up);
        }
        public void MoveS()
        {
            _playerController.Move(Vector2Int.down);
        }

        public void MoveE()
        {
            _playerController.Move(Vector2Int.right);
        }

        public void MoveW()
        {
            _playerController.Move(Vector2Int.left);
        }

        public void AttackFlyingEnemy()
        {
            _playerController.PlayerEntity().Attack(flyingEnemy.entity);
        }

        public void AttackGroundedEnemy()
        {
            _playerController.PlayerEntity().Attack(groundedEnemy.entity);
        }

        public void EnemyActions()
        {
            EnemyController[] enemies = FindObjectsOfType<EnemyController>();

            foreach (var e in enemies)
            {
                e.DoEnemyActions();
            }
            
        }
    }
}