using UnityEngine;

public interface IBattlePiece {

    void Move(IBattlePiece Target);

    void Attack(IBattlePiece Target);

    void ApplyEffect(IBattlePiece Target);


}