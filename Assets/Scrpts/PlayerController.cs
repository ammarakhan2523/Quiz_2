using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float forwardInput;
    float backwardInput;
    float speed = 2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis("Vertical");
        backwardInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * forwardInput * speed * Time.deltaTime);
        transform.Translate(Vector3.right * backwardInput * speed * Time.deltaTime);
    }
}
