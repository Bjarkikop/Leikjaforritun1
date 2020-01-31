using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 2000f;
    public float sidewaysForce = 500f; 
    bool isJumping = false;
    // Start is called before the first frame update
    void Start()
    {
        isJumping = false;

    }
    // Marked FixedUpdate because it alters physiscs
    void FixedUpdate()
    {
        
        if ( Input.GetKey("d") ) 
        {
            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
         if ( Input.GetKey("a") ) 
        {
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if ( Input.GetKey("space") && !isJumping ) 
        {   
           
            float JumpVelocity = 600f;
            rb.AddForce(Vector2.up * JumpVelocity);
            isJumping = true;
            
            
        }
    }
    private void OnCollisionEnter (Collision col)
    {
        if (col.gameObject.tag == "ground")
        {
            isJumping = false;
        }
    }
}
