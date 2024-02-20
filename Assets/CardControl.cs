using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    public Card card;
    public BoxCollider2D thisCard;
    public bool isMouseOver;
    private void Start()
    {
        thisCard = gameObject.GetComponent<BoxCollider2D>();

    }
    private void OnMouseOver()
    {
        isMouseOver = true;
    }
    private void OnMouseExit()
    {
        isMouseOver = false;
    }
}
public class Card
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
public enum CardSprite
{
    MAN1,
    MAN2,
    KNIGHT
}
