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
    Vector3 pos;
    public TMP_Text display;
    public TMP_Text dialogue;
    void Start()
    {
        
    }

    
    void Update()
    {
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
            
            dialogue.color.a = Mathf.Min(cardGameObject.transform.position.x, 1);
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                //cl
            }
        }
        //left side
        else if (cardGameObject.transform.position.x < -fSideMargin)
        {
            
            if (!Input.GetMouseButton(0) && cardGameObject.transform.position.x > fSideTrigger)
            {
                //cl
            }
        }
        else
        {
            cardSpriteRenderer.color = Color.white;
        }
    }
}
