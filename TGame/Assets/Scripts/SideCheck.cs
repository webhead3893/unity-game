using UnityEngine;

public class SideCheck : MonoBehaviour
{

    void OnTriggerEnter(){
        FindObjectOfType<GameManager>().EndGameNoD();
    }
}
