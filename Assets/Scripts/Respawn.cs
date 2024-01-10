using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 position;
    Quaternion rotation;

    [SerializeField] bool KeepRotation;
    void Start()
    {
        position = transform.position;
        rotation = transform.rotation;
        //Debug.Log(position.ToString());
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(transform.position.ToString());
        if (transform.position.y < -10)
        {
            transform.position = position;
            if (!KeepRotation)
            {
                transform.rotation = rotation;
            }
        }
    }
}
