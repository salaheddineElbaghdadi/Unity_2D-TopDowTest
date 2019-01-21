using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    ScriptableObjectsContainer container;


    void Awake()
    {
        container = gameObject.GetComponent<ScriptableObjectsContainer>();
    }

    // Update is called once per frame
    void Update()
    {
        container.characterMovement.speed.x = Input.GetAxis("Horizontal");
        container.characterMovement.speed.y = Input.GetAxis("Vertical");
    }
}
