using UnityEngine;

public abstract class ColliderHandle : MonoBehaviour
{
    ICollider colliderObject;
    string actual;

    void OnTriggerStay2D(Collider2D col)
    {
        string tag = col.tag;

        colliderObject = (actual != tag) ? ColliderFactory(tag) : colliderObject;

        if (null != colliderObject) 
        {
            colliderObject.IsColliding(col);
            actual = tag;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        string tag = col.tag;
        colliderObject = (actual != tag) ? ColliderFactory(tag) : colliderObject;

        if (null != colliderObject)
        {
            colliderObject.StopColliding(col);
            actual = tag;
        }
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        string tag = col.tag;
        colliderObject = (actual != tag) ? ColliderFactory(tag) : colliderObject;

        if (null != colliderObject)
        {
            colliderObject.EnterColliding(col);
            actual = tag;
        }
    }

    abstract ICollider ColliderFactory(string collider);
}