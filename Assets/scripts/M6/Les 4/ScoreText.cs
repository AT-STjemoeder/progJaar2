using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreText : MonoBehaviour
{
    PickUps Punten;
    private int score = 0;
    private TMP_Text TextField;
    // Start is called before the first frame update
    void Start()
    {
        TextField = GetComponent<TMP_Text>();
        PickUps.PlusPunten += Getscore;
    }

    // Update is called once per frame
    private void Getscore()
    {
        Debug.Log("plus");
        score += 50;
        TextField.text = "score" + score;

    }
    private void OnDisable()
    {
        PickUps.PlusPunten -= Getscore;
    }
}
