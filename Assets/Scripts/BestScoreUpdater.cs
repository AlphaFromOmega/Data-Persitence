using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BestScoreUpdater : MonoBehaviour
{
    private ScoreIO scoreSave;
    private Text text;
    // Start is called before the first frame update
    void Awake()
    {
        scoreSave = GameObject.Find("Game Manager").GetComponent<ScoreIO>();
        text = GetComponent<Text>();
        UpdateText($"Best Score: {scoreSave.bestScoreOwner} - {scoreSave.bestScore}");
    }
    void Update()
    {
        UpdateText($"Best Score: {scoreSave.bestScoreOwner} - {scoreSave.bestScore}");
    }
    public void UpdateText(string updatedText)
    {
        text.text = updatedText;
    }
}
