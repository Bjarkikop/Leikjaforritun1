using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //public breyta fyrir player
    public PLayerMovement movement;
    
    void OnCollisionEnter(Collision collisionInfo)
    {
        //ef player hittir obstacle
        if (collisionInfo.collider.tag == "Obstacle")
        {
            //Disablar movement og game over
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
            
        }
    }
}
