using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Notes : MonoBehaviour
{
    int NoteSpeed = 8;

    // Update is called once per frame
    void Update()
    {
        transform.position -= transform.forward*Time.deltaTime*NoteSpeed;
    }
}
