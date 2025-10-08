using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using static UnityEngine.EventSystems.EventTrigger;
public class enemy : MonoBehaviour
{

    public static event Action OnEnemyDeath;
    private int lives = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (lives <= 0)
        { 
            OnEnemyDeath?.Invoke();
            Destroy(gameObject);
        }
    }
    

}
