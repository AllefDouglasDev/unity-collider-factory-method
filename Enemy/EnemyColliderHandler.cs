using UnityEngine;

public class EnemyColliderHandler : PlayerColliderHandler
{
    ICollider colliderFactory(string collider)
    {
        collider = collider.ToLower();

        swicth(collider) {
            case "key":
                return new EnemyColKey();
            case "box":
                return new EnemyColBox();
            default:
                return null;
        }
    }
} 
