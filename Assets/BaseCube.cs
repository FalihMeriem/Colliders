using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseCube : MonoBehaviour
{
      /* private float speed=0.1f;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        this.transform.Translate(new Vector3(x,0,0));
    }*/
 public bool isClicked = false;
    public float speed = 4f;
    public float sensitivity = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.sensitivity = Input.GetAxis("Horizontal") * speed * 3;
        this.transform.Translate(
            new Vector3(
               sensitivity, 0,0
                )
            );
        if (Input.GetKey(KeyCode.LeftArrow) ||   Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.isClicked = true;

            // Print the current position of the cube to the console
            Debug.Log("Move to : " + this.transform.position);
        }
        this.isClicked = false;
    }

}

