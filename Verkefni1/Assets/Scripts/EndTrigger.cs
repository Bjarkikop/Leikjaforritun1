using UnityEngine;
using System.Collections;

public class EndTrigger : MonoBehaviour
{
    //Geri public breytu fyrir GameManager
    public GameManager gameManager;
    
    void OnTriggerEnter()
    {
        // Kallar á CompleteLevel
        gameManager.CompleteLevel();
    }
}
