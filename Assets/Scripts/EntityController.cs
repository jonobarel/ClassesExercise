using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using ZeroPrep.ClassesDemo;

public abstract class EntityController : MonoBehaviour
{
    public Entity entity;
    public Grid grid;
    private TextMeshPro tmp; 

    public Vector2Int CurrentPosition;
    public void Awake()
    {
        tmp = GetComponentInChildren<TextMeshPro>();
        
        
        grid = FindObjectOfType<Grid>();
    }
    
    public abstract void SetEntity();

    void Update()
    {
        CurrentPosition = entity.position;
        tmp.text = $"HP: {entity.Hp}";
        transform.position = grid.CellToWorld((Vector3Int)entity.position);
    }


}
