using UnityEngine;

public interface ICollider
{
    void IsColliding(Collider2D col);
    void StopColliding(Collider2D col);
    void EnterColliding(Collider2D col);
}
