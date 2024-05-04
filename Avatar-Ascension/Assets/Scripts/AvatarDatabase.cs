using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardDatabase : MonoBehaviour
{
   public static List<Card> cardList = new List<Card>();

   void Awake(){
    cardList.Add(new Card(0, "None", 0, 0, "None"));
    cardList.Add(new Card(1, "Red", 10, 2, "None"));
    cardList.Add(new Card(2, "Blue", 10, 2, "None"));
    cardList.Add(new Card(3, "Brown", 10, 2, "None"));
    cardList.Add(new Card(4, "Green", 10, 1, "None"));
    cardList.Add(new Card(5, "White", 10, 2, "None"));
    cardList.Add(new Card(6, "Black", 10, 1, "None"));
   }
}


