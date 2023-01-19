using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class positionChange : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 Change;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Change;
    }
}
