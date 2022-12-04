using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIGameOver : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    
    ScoreKeeper ScoreKeeper;

    void Awake()
    {
        ScoreKeeper = FindObjectOfType<ScoreKeeper>();
    }
    void Start()
    {
       scoreText.text = "YOU SCORED:\n" + ScoreKeeper.GetScore();            
    }

}
