using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Entity
{
    public override int Attack(Entity target)
    {
        if (DistanceTo(target) <= 1f)
        {
            target.TakeDamage(3);
            return 3;
        }
        return 0;
    }

    public virtual void DoEnemyActions()
    {
        MoveToTarget();
    }

    public void MoveToTarget()
    {
        Player player = FindObjectOfType<Player>();

        int xDelta = player.GridPosition.x - GridPosition.x;
        if (Mathf.Abs(xDelta) > 1)
        {
            Move(new Vector2Int((int)Mathf.Sign(xDelta),0));
        }

        else
        {
            int yDelta = player.GridPosition.y - GridPosition.y;
            if (Mathf.Abs(yDelta) > 1)
            {
                Move(new Vector2Int(0, (int)Mathf.Sign(yDelta)));
            }
        }
        
    }
}
