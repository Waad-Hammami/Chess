using UnityEngine;
using UnityEngine.UI;
using System.Collections;

// New
public enum CellState
{
    None,
    Friendly,
    Enemy,
    Free,
    OutOfBounds
}

public class Board : MonoBehaviour
{
    public GameObject mCellPrefab;

    [HideInInspector]
    public Cell[,] mAllCells = new Cell[8, 8];

    public void Create()
    {
 
    }

    public CellState ValidateCell(int targetX, int targetY, BasePiece checkingPiece)
    {   
        return CellState.Free;
    }
}
