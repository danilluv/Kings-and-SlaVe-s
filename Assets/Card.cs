using System.Collections;
using System.Collections.Generic;
using UnityEngine;
CreateAssetMenu
    public class Card : ScriptableObject

{
    public int cardId;
    public string cardName;
    public CardSprite sprite;
    public string leftQuote;
    public string rightQuote;
    public void Left()
    {
        Debug.Log(cardName + "swiped left");
    }
    public void Right()
    {
        Debug.Log(cardName + "swiped right");
    }
}