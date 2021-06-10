using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public string playerName = "";

    private ScoreIO scoreSave;
    private BestScoreUpdater bestScoreText;
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        scoreSave = GetComponent<ScoreIO>();
        scoreSave.LoadScore();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    public void UpdateName(string newName)
    {
        playerName = newName;
    }
}
