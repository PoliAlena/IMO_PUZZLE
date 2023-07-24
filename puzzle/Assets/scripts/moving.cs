using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class moving : MonoBehaviour
{
    bool move;

    Vector2 mouse;

    float x;
    float y;

    public GameObject cell;

    bool win;

    void OnMouseDown()
    {
        if(Input.GetMouseButtonDown(0))
        {
            move = true;
            mouse = Input.mousePosition;

            x = mouse.x - this.transform.localPosition.x;
            y = mouse.y - this.transform.localPosition.y;
        }
    }

    void OnMouseUp()
    {
        move = false;

        if(Mathf.Abs(this.transform.localPosition.x - cell.transform.localPosition.x)<=30f 
            && Mathf.Abs(this.transform.localPosition.y - cell.transform.localPosition.y) <= 30f && win != true)
        {
            this.transform.position= new Vector2(cell.transform.position.x, cell.transform.position.y);
            win = true;
            winwin.AddE();
        }
    }
    
    void Update()
    {
        if(move == true && win == false) 
        {
           mouse = Input.mousePosition;
           this.gameObject.transform.localPosition = new Vector2(mouse.x - x, mouse.y - y);
        }
    }
}
