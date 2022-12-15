using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5;
    public float userInput;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        userInput = Input.GetAxisRaw("Horizontal");
        transform.Translate(Vector2.right * userInput * moveSpeed * Time.deltaTime);   
    }
}
