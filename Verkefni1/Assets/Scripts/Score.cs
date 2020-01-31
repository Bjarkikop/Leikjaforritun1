using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    //public breytur fyrir player og text Score
    public Transform player;
    public Text scoreText;
    void Update()
    {
        //bætir við score
        scoreText.text = player.position.z.ToString("0");
    }
}
