using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {private set; get;}
    [Header("Panels")]
    [SerializeField] private GameObject pregamePanel;
    [SerializeField] private GameObject turnIndicator;


    private int numberOfPlayers;

    private void Awake(){
        if (Instance == null){
            Instance = this;
        }
        else{
            Destroy(this.gameObject);
            return;
        }

        if (turnIndicator != null){
            turnIndicator.SetActive(false);
        }

        if (pregamePanel != null){
            pregamePanel.SetActive(true);
        }
    }

    public void SetNumberOfPlayers (string players){
        try{
            numberOfPlayers = int.Parse(players);
        }
        catch(UnityException e){
            numberOfPlayers = 0;
        }
        Debug.Log($"Number of players set to {numberOfPlayers}");
    }

    public void PrepareGame(){
        if(numberOfPlayers > 0){
            pregamePanel.SetActive(false);
            Debug.Log("The game has begun!");
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
