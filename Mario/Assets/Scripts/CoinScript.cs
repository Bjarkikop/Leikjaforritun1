using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CoinScript : MonoBehaviour
{
    //Bý til GameObject fyrir coin texta
    public GameObject scoreText;
    //Breyta fyrir points
    public int points = 1;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Lætur pening snúast
        transform.Rotate(90 * Time.deltaTime, 0, 0);
        
    }
    void scoreUpdate(){
        //update coins 
        scoreText.GetComponent<Text>().text = "Coins: " + points;
        //Ef það er collectad öllum(1 coin í bili) þá er loadað næsta scene
        if (points == 1){
                //resetar points
                points= 0;
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                
            }
    }
    void OnTriggerEnter(Collider other){
        //ef coin colidar við player
        if(other.tag == "player"){
            //hækka points
            points++;
            //aipdata score
            scoreUpdate();
            //eyðilegg peningin
            Destroy(gameObject);
            
            
        }
    }
     

    
}


