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

public enum CardSprite
{
    MAN1,
    MAN2,
    KNIGHT
}
