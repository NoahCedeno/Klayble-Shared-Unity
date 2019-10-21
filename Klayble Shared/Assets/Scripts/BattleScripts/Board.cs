using System.Collections.Generic;
using UnityEngine;

namespace BattleSystem
{
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

        /* TODO: Slap this bad boy in the TurnSystem maybe? There's definitely a better place for this guy.
        public void ApplyEffect(TileScript Tile, BattleCharacter.Effects effect)
        {
            BattlePiece target = GetBattlePieceAt(Tile);
            if(target is BattleCharacter) {
                target = (BattleCharacter) target;
                target.ApplyEffect(effect);
            }
        }
        */

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
}