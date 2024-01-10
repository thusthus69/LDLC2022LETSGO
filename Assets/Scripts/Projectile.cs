using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    Rigidbody rigidbody;
    [SerializeField] float speed = 5f;
    [SerializeField] float lifetime = 5f;

    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();
        Invoke("Destruction", lifetime);
    }

    void FixedUpdate()
    {
        Vector3 currentPosition = transform.position;
        Vector3 direction = transform.forward;

        Vector3 newPosition = currentPosition + direction * speed * Time.deltaTime;

        rigidbody.MovePosition(newPosition);
    }

    void OnCollisionEnter(Collision collision)
    {
        Renderer renderer = collision.gameObject.GetComponent<Renderer>();
        if(renderer != null)
        {
            renderer.material.color = Random.ColorHSV();
        } 
    }

    void Destruction()
    {
        Destroy(gameObject);
    }
}