using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private List<BattlePiece> BattlePieces { get; set; }
    [SerializeField] private TileScript[,] TileBoard { get; set; }

    private void Start()
    {
        TileBoard = new TileScript[6, 6];
        BattlePieces = new List<BattlePiece>();
    }

    private GameObject ObjectOnTile(TileScript Tile)
    {
        if (Physics.Raycast(Tile.transform.position, Vector3.up, out RaycastHit Hit))
        {
            return Hit.collider.gameObject;
        }
        else
        {
            return null;
        }
    }
    
    public BattlePiece GetBattlePieceAt(TileScript Tile)
    {
        return ObjectOnTile(Tile).GetComponent<BattlePiece>();
    }
}