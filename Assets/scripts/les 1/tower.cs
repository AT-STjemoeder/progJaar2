using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Tower;
    private void createTower()
    {
        Vector3 Randompos = new Vector3(Random.Range(-2f,2f),0f, Random.Range(-2f,2f));
        Instantiate(Tower, Randompos, Quaternion.identity);

    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            createTower();
        }  
    }
}
