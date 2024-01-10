using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    Vector3 origineposition;
    float speed = -2f;
    Rigidbody rigidbody;

        void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        origineposition = transform.position;
    }

    void Update()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = new Vector3(1f, 0f, 0f);
        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;
        if (currentPosition.x <= origineposition.x - 2f || currentPosition.x > origineposition.x)
        {
            speed *= -1f;
        }
        rigidbody.MovePosition(newPosition);
    }
}