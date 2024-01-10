using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerShoot : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    // Update is called once per frame
    void Update()
    {
        //Effectuer une action lorsque l'utilisateur clique (dans l'Update) :
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            Instantiate(projectilePrefab, Camera.main.transform.position + Camera.main.transform.forward * 2, Camera.main.transform.rotation);
        }
    }
}