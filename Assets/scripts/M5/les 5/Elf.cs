using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elf : EnemyParent
{
    // Start is called before the first frame update
    void Start()
    {
        lives = 1f;
        Snel = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        move();
        death();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kogel"))
        {
            Destroy(gameObject);
        }
    }
}
