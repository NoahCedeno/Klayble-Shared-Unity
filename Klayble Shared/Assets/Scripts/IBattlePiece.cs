public interface IBattlePiece
{
    void Move(TileScript Target);

    void Attack(TileScript Target);

    void ApplyEffect(TileScript Target);
}