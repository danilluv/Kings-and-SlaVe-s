using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject cardGameObject;
    public CardControl mainCardControl;
    public SpriteRenderer cardSpriteRenderer;
    public float fMovingSpeed;
    public float fSideMargin;
    public float fSideTrigger;
    float alphaText;
    
    Vector3 pos;
    public TMP_Text display;
    public TMP_Text dialogue;
    void Start()
    {
        
    }

    
    void Update()
    {
        alphaText = Mathf.Min(Mathf.Abs(cardGameObject.transform.position.x), 1);
        //movement
        if (Input.GetMouseButton(0) && mainCardControl.isMouseOver)
        {
            Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            cardGameObject.transform.position = pos;
        }
        else
        {
            cardGameObject.transform.position = Vector2.MoveTowards(cardGameObject.transform.position, new Vector2(0, 0), fMovingSpeed);
        }
        //cheking the side
        //right side
        if (cardGameObject.transform.position.x > fSideMargin)
        {
            
            dialogue.alpha = Mathf.Min(cardGameObject.transform.position.x, 1);
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                Debug.Log("Gone left")
            }
        }
        //left side
        else if (cardGameObject.transform.position.x < -fSideMargin)
        {
            dialogue.alpha = Mathf.Min(cardGameObject.transform.position.x, 1);
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                Debug.Log("Gone right")
            }
        }
        else
        {
            cardSpriteRenderer.color = Color.white;
        }
        //ui
        display.text = "" + alphaText;
    }
}
