using System.Collections;
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
        StartCoroutine(FunnyBusiness());
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

    // Once event OnMove is heard here, apply effect
    public void ApplyEffect(BattlePiece Target, TileScript Tile)
    {
        GetBattlePieceAt(Tile).ApplyEffect(BattlePiece.Effects.Normal);
    }

    private void InitializeTileBoard()
    {
        for(int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 6; j++)
            {
                TileBoard[i, j] = GameObject.Find("Tile" + i.ToString() + j.ToString()).GetComponent<TileScript>();
            }
        }
    }

    IEnumerator FunnyBusiness() // TODO: Delete this >:(
    {
        Vector3 endMarker = new Vector3(0, 2, 0);
        float speed = 1f;

        for (int i = 0; i <= 6; i++)
        {
            for (int j = 0; j <= 6; j++)
            {
                /* while (TileBoard[i, j].transform.position != endMarker THIS LOOP STINKS IT LOOPS FOREVER
                {
                    float startTime = Time.time;
                    float journeyLength = Vector3.Distance(TileBoard[i, j].transform.position, endMarker);
                    float distCovered = (Time.time - startTime) * speed;
                    float fracJourney = distCovered / journeyLength;
                    
                    TileBoard[i, j].transform.position = Vector3.Lerp(TileBoard[i, j].transform.position, endMarker, fracJourney);
                } */
                yield return new WaitForSecondsRealtime(0.1f);
            }
        }
    }
}