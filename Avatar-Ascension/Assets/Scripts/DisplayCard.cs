using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using TMPro;

public class DisplayCard : MonoBehaviour
{
    public Card displayCard;
    public int displayId;

    public int id;
    public string cardName;
    public int health;
    public int power;
    public string cardDescription;

    public TextMeshProUGUI nameText;
    public TextMeshProUGUI powerText;
    public TextMeshProUGUI descriptionText;

    // Start is called before the first frame update
    void Start()
    {
        displayCard = CardDatabase.cardList[displayId];
        id = displayCard.id;

        
        cardName = displayCard.cardName;
        health = displayCard.health;
        power = displayCard.power;
        cardDescription = displayCard.cardDescription;


        nameText.text = cardName;
        powerText.text = "Power: " + power;
        descriptionText.text = cardDescription;
    }

    // Update is called once per frame
    void Update()
    {

    
    }
}
