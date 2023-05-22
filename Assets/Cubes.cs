using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubes : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }
private void OnCollisionEnter(Collision collision)
{
    
    Destroy(this.transform.gameObject);
   
}
    // Update is called once per frame
    void Update()
    {
        
    }
}
