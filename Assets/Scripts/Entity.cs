using TMPro;
using UnityEngine;
using ZeroPrep.ClassesDemo;

public abstract class Entity : MonoBehaviour //, IDamageable
{
    public int HP;
    public Grid grid;
    private TextMeshPro tmp;

    public Vector2Int GridPosition;
    public void Awake()
    {
        tmp = GetComponentInChildren<TextMeshPro>();
        grid = FindObjectOfType<Grid>();
        SnapPositionToGrid();
    }
    
    public abstract int Attack(Entity target);
    
    public virtual void Move(Vector2Int targetPosition)
    {
        GridPosition += targetPosition;
        transform.position = grid.CellToWorld((Vector3Int)GridPosition);
    }

    public void SnapPositionToGrid()
    {
        Vector2Int snappedGridPosition = (Vector2Int)grid.WorldToCell(transform.position);
        Move(snappedGridPosition);
    }

    public virtual void TakeDamage(int damage)
    {
        HP -= damage;
        HP = Mathf.Min(0, HP);
        tmp.text = $"HP: {HP}";
    }
    
}
