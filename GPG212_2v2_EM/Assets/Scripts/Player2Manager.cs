using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2Manager : MonoBehaviour
{
    float distance = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * distance);
        }

        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * distance );
        }

        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * distance);
        }

        if(Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.forward * -distance);
        }
    }
}
