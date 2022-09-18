
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
   public movement move;
 
   void OnCollisionEnter (Collision collisionInfo)
   {
   
        if (collisionInfo.collider.tag == "Obstacle")
        {
            move.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
   }
}
