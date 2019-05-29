using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] public int NumTurns { get; private set; }
    [SerializeField] public Player Player1 { get; private set; }
    [SerializeField] public Player Player2 { get; private set; }
    [SerializeField] private Board Board { get; set; }

    // Start is called before the first frame update
    private void Start()
    {
    }

    // Update is called once per frame
    private void Update()
    {
    }
}