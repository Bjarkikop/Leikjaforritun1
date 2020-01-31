using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    //bool breyta fyrir end game
   bool gameHasEnded = false;
   //restart delay þegar þý deyrð
   public float restartDelay = 1f;
    // gameObject fyrir Complete level texta
   public GameObject completeLevelUI;

   public void CompleteLevel()
   {    
       //Kalla á textann
       completeLevelUI.SetActive(true);

   }

   public void EndGame()
   {
       //ef Leikur er búinn Þá hættir leikur
       if (gameHasEnded == false) 
       {
           gameHasEnded = true;
           Debug.Log("Game OVer");
           Invoke("Restart", restartDelay);
       }

   }
       void Restart ()
       {
           //loadar scene þar sem þú dóst
           SceneManager.LoadScene(SceneManager.GetActiveScene().name);
       }
   
   
}
