using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyParent : MonoBehaviour
{
    public float Snel;
    public float lives;
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
     
    }
    protected void move()
    {
        transform.Translate(Vector3.right * Snel * Time.deltaTime);
    }
    protected void death()
    {
        if (lives == 0f)
        {
            Snel = 0f;
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Kogel"))
        {
            lives -= 1f;
        }
    }
}
