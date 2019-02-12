using UnityEngine;

public class PlayerColKey : ICollider
{
    public void EnterColliding(Collider2D col)
    {
       print("Player totou a chave");
    }

    public void IsColliding(Collider2D col)
    {
         print("Player cotinua tocando a chave");
    }

    public void StopColliding(Collider2D col)
    {
         print("Player parou de tocar a chave");
    }
}