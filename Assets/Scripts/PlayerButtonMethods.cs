using System;
using UnityEngine;

namespace ZeroPrep.ClassesDemo
{
    public class PlayerButtonMethods : MonoBehaviour
    {
        private Player _player;
        public Enemy flyingEnemy;
        public Enemy groundedEnemy;

        public void Awake()
        {
            if (flyingEnemy == null || groundedEnemy == null)
            {
                throw new ArgumentNullException($"{name}: Enemies not set up in UI");
            }
            _player = GetComponent<Player>();
            if (_player != null)
            {
                EquipSword();
            }

            else
            {
                throw new ArgumentNullException($"{name}: Could not find Player object in scene");
            } 
                
        }

        public void Start()
        {
            
        }
        
        public void EquipSword()
        {
        }

        public void EquipBow()
        {
        }
        
        public void MoveUp()
        {
            _player.Move(Vector2Int.up);
        }
        public void MoveDown()
        {
            _player.Move(Vector2Int.down);
        }

        public void MoveRight()
        {
            _player.Move(Vector2Int.right);
        }

        public void MoveLeft()
        {
            _player.Move(Vector2Int.left);
        }

        public void AttackFlyingEnemy()
        {
        }

        public void AttackGroundedEnemy()
        {
        }

        public void EnemyActions()
        {
            Enemy[] enemies = FindObjectsOfType<Enemy>();

            foreach (Enemy e in enemies)
            {
                e.DoEnemyActions();
            }
            
        }
    }
}