using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;
    public SideCheck sideCheck;

    void OnCollisionEnter(Collision collisionInfo){
        if(collisionInfo.collider.tag == "Obstacle"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
        if(collisionInfo.collider.tag == "End"){
            movement.enabled = false;
            FindObjectOfType<GameManager>().Invoke("CompleteLevel", 1f);
        }
    }
}