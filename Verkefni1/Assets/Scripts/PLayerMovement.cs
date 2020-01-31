using UnityEngine;

public class PLayerMovement : MonoBehaviour
{
    // breytur fyrir Rigid body og force áfram og á aftur á bak
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
    // Start is called before the first frame update
    void Start()
    {
        

    }
    // FixedUpdate breytir eðlisfræðinni
    void FixedUpdate()
    {
        // bæti við force áfram
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);
        //if setningar ef það er ýtt á takka og bætir við force á þá átt
        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if ( Input.GetKey("a") ) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //ef player hefur dottið af platforms
        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
