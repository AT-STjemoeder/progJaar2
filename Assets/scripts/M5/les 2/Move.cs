using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float Velocity;
    [SerializeField] private float RotSpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       float translation = Input.GetAxis("Vertical") * Velocity;
       float rotation = Input.GetAxis("Horizontal") * RotSpeed;

        translation *= Time.deltaTime;
        
        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);


    }
}
