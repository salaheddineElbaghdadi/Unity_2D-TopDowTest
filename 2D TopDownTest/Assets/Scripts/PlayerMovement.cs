using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    // Scriptable objects
    ScriptableObjectsContainer container;
    Rigidbody2D rigidbody2d;

    // Start is called before the first frame update
    void Awake()
    {
        rigidbody2d = gameObject.GetComponent<Rigidbody2D>();
        container = gameObject.GetComponent<ScriptableObjectsContainer>();
    }

    // Update is called once per frame
    void Update()
    {
        rigidbody2d.velocity = container.characterMovement.maxSpeed * container.characterMovement.speed.normalized * Time.deltaTime;
    }
}
