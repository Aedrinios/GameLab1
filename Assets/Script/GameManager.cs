using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField]
    private List<GameObject> ingredients;
    [SerializeField]
    private List<GameObject> currentCommand;
    private int commandSize = 4;

    

    private void Start()
    {
        CreateCommand();
    }

    private void CreateCommand()
    {
        for(int i = 0; i < commandSize; i++)
        {
            currentCommand.Add(ingredients[Random.Range(0, ingredients.Count)]);

        }
    }

    private void Update()
    {
        
    }
}
