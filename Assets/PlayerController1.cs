using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController1 : MonoBehaviour
{
    public float turnSpeed = 10.0f;
    public Vector3 scaleChange;
    public float horizontalInput;
    public float verticalInput;
    


    // Start is called before the first frame update
    void Start()
    {
     scaleChange = new Vector3(0.01f, 0.01f, 0.01f);
    }

    // Update is called once per frame
    void Update()
    {
        // get the user's horizontal input
        horizontalInput = Input.GetAxis("Horizontal");

        // get the user's vertical input
        verticalInput = Input.GetAxis("Vertical");
        

       if (Input.GetKey(KeyCode.Space))
        {
            //scaleChange.Set(0.01f, 0.01f, 0.01f);
            transform.localScale += scaleChange;
        }

        else if (Input.GetKey(KeyCode.B))
        {
           // scaleChange.Set(1.0f, 1.0f, 1.0f);
            transform.localScale -= scaleChange;
        }
        // Rotate the player up/down based on up/down arrow keys
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * horizontalInput);

        // Rotate the player right/left based on right/left arrow keys
        transform.Rotate(Vector3.right, Time.deltaTime * turnSpeed * verticalInput);

      
    }
}