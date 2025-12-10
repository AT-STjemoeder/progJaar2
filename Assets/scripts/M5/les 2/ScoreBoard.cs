using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class ScoreBoard : MonoBehaviour
{
    private int score = 0;
    private TMP_Text TextField;
    // Start is called before the first frame update
    void Start()
    {
        TextField = GetComponent<TMP_Text>();
        PickUp.onPickUp += Getscore;
    }

    // Update is called once per frame
    private void Getscore()
    {
        score += 50;
        TextField.text = "score" +score;

    }
}
