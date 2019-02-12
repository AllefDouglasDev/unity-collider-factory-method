using UnityEngine;

public class EnemyColKey : ICollider
{
    public void EnterColliding(Collider2D col)
    {
       print("Enemy totou a chave");
    }

    public void IsColliding(Collider2D col)
    {
         print("Enemy cotinua tocando a chave");
    }

    public void StopColliding(Collider2D col)
    {
         print("Enemy parou de tocar a chave");
    }
}