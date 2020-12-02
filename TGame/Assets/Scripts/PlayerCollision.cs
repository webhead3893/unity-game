using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collisionInfo.collider.tag == "End"){
            movement.enabled = false;
            gameManager.Invoke("CompleteLevel", 2f);
        }
    }
}