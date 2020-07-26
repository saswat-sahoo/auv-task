
using UnityEngine;

public class movement : MonoBehaviour
{
   
    public Rigidbody rb;
    private Transform playerTranform;
    public float speed = 10;
    

    


    // Start is called before the first frame update
    void Start()
    {
        
        rb = GetComponent<Rigidbody>();
        this.rb.useGravity = false;
        

    }
    

   
    
    void FixedUpdate()
    {
        if (Input.GetKey("g")) { this.rb.useGravity = true;  }
        if (Input.GetKey("h")) { this.rb.useGravity = false;  }

       

        if (Input.GetKey("w"))
        {
            
            transform.position += (transform.right * (-speed ) * Time.deltaTime);

        }

        if (Input.GetKey("s"))
        {
            transform.position += (transform.right* (speed) * Time.deltaTime);
        }
        if (Input.GetKey("a"))
        {

            transform.position += (transform.forward * (-speed) * Time.deltaTime);

        }
        if (Input.GetKey("d"))
        {
            transform.position += (transform.forward * (speed) * Time.deltaTime);

        }

        
        
            if (Input.GetKey("up"))
            {

                rb.velocity = Vector3.zero;
                transform.position += (transform.up * (speed) * Time.deltaTime);
            }

            if (Input.GetKey("down"))
            {
                rb.velocity = Vector3.zero;

                transform.position += (transform.up * (-speed) * Time.deltaTime);

            }
        
      


        {
            if (Input.GetKey("right"))
            {
                rb.angularVelocity = rb.transform.up * (speed*5 ) * Time.deltaTime;
               
            }

            else if (Input.GetKey("left"))
            {
                rb.angularVelocity = rb.transform.up * (-speed*5) * Time.deltaTime;
            }

            else rb.angularVelocity = rb.transform.up * 0;
        }


        
       
       
        
        if (Input.GetKey("space"))
        {
            
            transform.rotation = Quaternion.Euler(0,90 , 0);
            
        }
       
    }


    


}
