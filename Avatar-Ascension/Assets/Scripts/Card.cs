using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]

public class Card
{
   public int id;
   public string cardName;
   public int health;
   public int power;
   public string cardDescription;

   public Card(){

   }

   public Card(int Id, string CardName, int Health, int Power, string CardDescription){
    id = Id;
    cardName = CardName;
    health = Health;
    power = Power;
    cardDescription = CardDescription;

   }


}

