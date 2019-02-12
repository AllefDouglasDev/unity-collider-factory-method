using UnityEngine;

public class PlayerColliderHandler : PlayerColliderHandler
{
    ICollider colliderFactory(string collider)
    {
        collider = collider.ToLower();

        swicth(collider) {
            case "key":
                return new PlayerColKey();
            case "box":
                return new PlayerColBox();
            default:
                return null;
        }
    }
} 
