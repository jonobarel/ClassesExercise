using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ZeroPrep.ClassesDemo;

public class EnemyController : EntityController
{
    public enum EnemyType
    {
        Flying,
        Grounded
    }

    public EnemyType type;
    public EntityController playerGameObject;

    public new void Awake()
    {
        base.Awake();
        playerGameObject = FindObjectOfType<PlayerController>();
    }
    public void DoEnemyActions()
    {
        ((Enemy)entity).DoActions();
    }

    public void Start()
    {
        SetEntity();
        entity.position = (Vector2Int)grid.WorldToCell(transform.position);
    }

    public override void SetEntity()
    {
        Player player = (Player)playerGameObject.entity;
        switch (type)
        {
            case (EnemyType.Flying):
                entity = new FlyingEnemy(player);
                break;
            case (EnemyType.Grounded):
                entity = new GroundEnemy(player);
                break;
        }
    }
    
    
}
