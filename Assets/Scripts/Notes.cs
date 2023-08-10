using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    int NoteSpeed = 8;
    bool start;

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            start = true;
        }
        if(start)
        { 
            transform.position -= transform.forward*Time.deltaTime*NoteSpeed;
        }
    }
}
