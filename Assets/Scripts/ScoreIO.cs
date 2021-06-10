using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class ScoreIO : MonoBehaviour
{
    public int bestScore = 0;
    public string bestScoreOwner = "";

    [System.Serializable]
    class SaveData
    {
        public int bestScore;
        public string bestScoreOwner;
    }

    public void SaveScore()
    {
        SaveData data = new SaveData();
        data.bestScore = bestScore;
        data.bestScoreOwner = bestScoreOwner;

        string json = JsonUtility.ToJson(data);

        File.WriteAllText(Application.persistentDataPath + "/savefile.json", json);
    }
    public void LoadScore()
    {
        string path = Application.persistentDataPath + "/savefile.json";
        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            SaveData data = JsonUtility.FromJson<SaveData>(json);

            bestScore = data.bestScore;
            bestScoreOwner = data.bestScoreOwner;
        }
    }

}
