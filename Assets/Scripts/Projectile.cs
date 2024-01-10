using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    
    AudioSource audioSource;
    Rigidbody rigidbody;
    [SerializeField] float speed = 5f;
    [SerializeField] float lifetime = 5f;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
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
            audioSource.Play();
            audioSource.pitch = Random.Range(0.1f, 3f);
        } 
    }

    void Destruction()
    {
        Destroy(gameObject);
    }
}