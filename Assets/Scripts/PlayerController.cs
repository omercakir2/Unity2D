using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 100f;
    public InputAction MoveAction;
    void Start()
    {
        MoveAction.Enable();
    }


    // Update is called once per frame
    void Update()
    {
        Vector2 move = MoveAction.ReadValue<Vector2>();
        Debug.Log(move);
        Vector2 position = (Vector2)transform.position + move * speed *Time.deltaTime;
        transform.position = position;
    }
}
