using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class tower : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject Tower;
    

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

    private void createTower()
    {



        Vector3 Randompos = new Vector3(Random.Range(-10f, 10f), 0f, Random.Range(-10f, 10f));

        Vector3 RandomScale = new Vector3(Random.Range(0f, 5f), Random.Range(0f, 4f), Random.Range(0f, 5f));


        Tower.transform.localScale = RandomScale;

        Instantiate(Tower, Randompos, Quaternion.identity);


    }
}
