using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> ingredients;
    [SerializeField]
    private List<GameObject> currentCommand;
    [SerializeField]
    private Transform uiCommand;
    [SerializeField]
    private GameObject victoryScreen;



    private int commandSize = 4;

    private void Start()
    {
        CreateCommand();
    }

    private void CreateCommand()
    {
        for(int i = 0; i < commandSize; i++)
        {
            GameObject go = ingredients[Random.Range(0, ingredients.Count)];
            currentCommand.Add(go);
            uiCommand.GetChild(i).GetComponent<TextMeshProUGUI>().text = go.name;
        }
    }

    public void WinGame()
    {
        victoryScreen.SetActive(true);
    }
}
