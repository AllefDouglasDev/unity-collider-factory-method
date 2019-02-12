using UnityEngine;

public class PlayerColBoc : ICollider
{
    public void EnterColliding(Collider2D col)
    {
       print("Player totou a caixa");
    }

    public void IsColliding(Collider2D col)
    {
         print("Player cotinua tocando a caixa");
    }

    public void StopColliding(Collider2D col)
    {
         print("Player parou de tocar a caixa");
    }
}