using UnityEngine;

public class EnemyColBoc : ICollider
{
    public void EnterColliding(Collider2D col)
    {
       print("Enemy totou a caixa");
    }

    public void IsColliding(Collider2D col)
    {
         print("Enemy cotinua tocando a caixa");
    }

    public void StopColliding(Collider2D col)
    {
         print("Enemy parou de tocar a caixa");
    }
}