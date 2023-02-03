using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizon = Input.GetAxis("Horizontal");
        Input.GetAxisRaw
        transform.Translate(new Vector3(horizon,0,0));
        Debug.Log(horizon);
    }
}
