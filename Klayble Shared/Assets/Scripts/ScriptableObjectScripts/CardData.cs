using UnityEngine;

[CreateAssetMenu(fileName = "New CardData", menuName = "ScriptableObjects/CardDataScriptableObject", order = 1)]
public class CardData : ScriptableObject
{
    [SerializeField]
    public int CardID, Level, HP, Atk, Def;

    [SerializeField]
    public string Name;

    [SerializeField]
    public Player Player;
}

/**
 * TODO: Organize Models by CardID number!
 * In BattleCard, there will be a reference to the model
 * or renderer that should be able to find the appropriate
 * model for the Card in question via CardID.
 */