using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour
{

    public float speed = 1.0f;
    public KeyCode forwardKey;
    public KeyCode rightKey;
    public KeyCode leftKey;
    public KeyCode backKey;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(forwardKey))
        {
            transform.Translate(Vector3.forward * speed);
           
        }

        if(Input.GetKeyDown(rightKey))
        {
            transform.Translate(Vector3.right * speed);
            
        }

        if(Input.GetKeyDown(leftKey))
        {
            transform.Translate(Vector3.left * speed);
            
        }
        
        if(Input.GetKeyDown(backKey))
        {
            transform.Translate(Vector3.forward * -speed);
        }
    }

}
