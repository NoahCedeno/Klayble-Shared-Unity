using UnityEngine;
using Newtonsoft.Json;

public class Card : MonoBehaviour
{
    [SerializeField] public int HP { get; private set; }
    [SerializeField] public int Atk { get; private set; }
    [SerializeField] public int Def { get; private set; }
    [SerializeField] public string Name { get; private set; }
    [SerializeField] public int CardID { get; set; }
    [SerializeField] public Player Player { get; set; }

    private void OnEnable()
    {
        Debug.Log("Card " + Name + " made under owner " + Player.Name);
    }

    private void loadCardData(int CardID)
    {
        // Deserialize and Load from file.
    }

}