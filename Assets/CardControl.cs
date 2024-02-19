using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardControl : MonoBehaviour
{
    public BoxCollider2D thisCard;
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
