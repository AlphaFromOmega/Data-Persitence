using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NameFieldEntry : MonoBehaviour
{
    private GameObject gameManager;
    private InputField inputField;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager");
        inputField = GetComponent<InputField>();
        inputField.onValueChanged.AddListener(UpdateName);
    }

    // Update is called once per frame
    void UpdateName(string newName)
    {
        gameManager.GetComponent<GameManager>().playerName = newName;
    }
}
