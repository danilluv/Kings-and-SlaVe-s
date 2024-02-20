using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //Gameobjects
    public GameObject cardGameObject;
    public CardControl mainCardControl;
    public SpriteRenderer cardSpriteRenderer;
    public ResourseManager resourseManager;
    //tweaking variables
    public float fMovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    float alphaText;
    Color textColor;
    Vector3 pos;
    //ui
    public TMP_Text display;
    public TMP_Text dialogue;
    public TMP_Text character;
    //card variables
    private string leftQuote;
    private string rightQuote;
    Card currentCard;
    Card testCard;

    void Start()
    {
        LoadCard(testCard);
    }

    
    void Update()
    {
        //dialogue handing
        textColor.a = Mathf.Min(Mathf.Abs(cardGameObject.transform.position.x/2), 1);
        dialogue.color = textColor;
        //movement
        if (Input.GetMouseButton(0) && mainCardControl.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
        }
        else
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, new Vector2(0, 1), fMovingSpeed);
        }
        //cheking the side
        //right side
        if (cardGameObject.transform.position.x > fSideMargin)
        {
            
            dialogue.alpha = Mathf.Min(cardGameObject.transform.position.x, 1);
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                Debug.Log("Gone left");
            }
        }
        //left side
        else if (cardGameObject.transform.position.x < -fSideMargin)
        {
            dialogue.alpha = Mathf.Min(cardGameObject.transform.position.x, 1);
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                Debug.Log("Gone right");
            }
        }
        else
        {
            cardSpriteRenderer.color = Color.white;
        }
        //ui
        display.text = "" + textColor.a;
    }

    public void LoadCard(Card card)
    {
        cardSpriteRenderer.sprite = resourseManager.sprites[(int)card.sprite];
        leftQuote = card.leftQuote;
        rightQuote = card.rightQuote;
        curentCard = card;
    }
}
