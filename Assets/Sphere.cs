using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : MonoBehaviour
{
    
    // Start is called before the first frame update
    /*void Start()
    {
    }
    private void OnCollisionEnter(Collision Collision){
        Debug.Log("A collision has been detected");
        this.GetComponent<Rigidbody>().AddForce(1,500,0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }*/


    public BaseCube basecube;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "MyCubes")
        {
            Debug.Log("collision with the target");
        }
        else if(collision.gameObject.tag == "Planes") {
                 Destroy(this.transform.gameObject);
        }
        else
        {
            
            Debug.Log("A collision with basecube has been detected");
        this.GetComponent<Rigidbody>().AddForce(1,500,0);
         
        }
        
    }
}

