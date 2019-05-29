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

    public IBattlePiece ObjectOnTile(TileScript Tile)
    {
        RaycastHit Hit;
        if(Physics.Raycast(Tile.transform.position, Vector3.up, out Hit))
        {
            return Hit.collider.gameObject.GetComponents<Card, DeckMaster>;
        }
    }

}