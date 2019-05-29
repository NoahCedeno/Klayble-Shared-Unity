using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] private List<IBattlePiece> BattlePieces { get; set; }
    [SerializeField] private TileScript[,] TileBoard { get; set; }

    // Initialization
    private void Start()
    {
        TileBoard = new TileScript[6, 6];
        BattlePieces = new List<IBattlePiece>();
    }

    private GameObject ObjectOnTile(TileScript Tile) // Unsure how to return multiple Components here. Perhaps just the GameObject?
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

    // How to return the Type of Component as an IBattlePiece? We'd have to see if this works.
    public IBattlePiece GetPieceOnTile(TileScript Tile)
    {
        return ObjectOnTile(Tile).GetComponent<IBattlePiece>();
    }
}