using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float Velocity1;
    [SerializeField] private float RotSpeed1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float translation = Input.GetAxis("Vertical") * Velocity1;
        float rotation = Input.GetAxis("Horizontal") * RotSpeed1;

        translation *= Time.deltaTime;

        transform.Translate(0, 0, translation);
        transform.Rotate(0, rotation, 0);


    }
}
