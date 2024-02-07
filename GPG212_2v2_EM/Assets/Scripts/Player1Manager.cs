using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1Manager : MonoBehaviour
{

    float distance = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Time = 1.0f; 

        if(Input.GetKeyDown("w"))
        {
            transform.Translate(Vector3.forward * distance);
            Debug.Log($"This fired");
        }

        if(Input.GetKeyDown("d"))
        {
            transform.Translate(Vector3.right * distance);
             Debug.Log($"This fired");
        }

        if(Input.GetKeyDown("a"))
        {
            transform.Translate(Vector3.left * distance);
             Debug.Log($"This fired");
        }
        
        if(Input.GetKeyDown("s"))
        {
            transform.Translate(Vector3.forward * -distance);
        }
    }

    public void PlayerMovement()
    {
       
     transform.Translate(Vector3.forward * Time.deltaTime);
      
    }
}
