using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private List<BattlePiece> BattlePieces { get; set; }
    [SerializeField] public TileScript[,] TileBoard { get; set; }

    private void Start()
    {
        TileBoard = new TileScript[6, 6];
        BattlePieces = new List<BattlePiece>();
        InitializeTileBoard();
    }

    // TODO: NEVER TESTED THIS RAYCAST ATTEMPT, MUST AT SOME POINT
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

    // Once event OnMove is heard here, apply effect
    public void ApplyEffect(BattlePiece Target, TileScript Tile)
    {
        GetBattlePieceAt(Tile).ApplyEffect(BattlePiece.Effects.Normal);
    }

    private void InitializeTileBoard()
    {
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                TileBoard[i, j] = GameObject.Find("Tile" + i.ToString() + j.ToString()).GetComponent<TileScript>();
            }
        }
    }
}