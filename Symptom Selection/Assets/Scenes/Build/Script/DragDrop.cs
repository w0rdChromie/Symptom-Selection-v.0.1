using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler, IDropHandler
{
    [SerializeField] private Canvas canvas; // fixed ratio for the dragged image to the canvas

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    private CheckScore CC;
    public bool canDrag;
    public Image NameOfDis;
    
    private void Awake()
    
    {
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
        CC = GetComponent<CheckScore>();
       
    }
    void Start()
    {
        canDrag = true;
        
    }


    public void OnBeginDrag(PointerEventData eventData)
    {
        //Debug.Log("OnBeginDrag");
       
            canvasGroup.alpha = .6f; // become transparent when dragged
            canvasGroup.blocksRaycasts = false; // turn off the raycast
        
    }

    public void OnDrag(PointerEventData eventData)
    {
        if (canDrag == true)
        {
            rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor; // change the position of the dragged image depended on the canvas scale
        }
        //Debug.Log("OnDrag");
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (canDrag == true)
        {
            //Debug.Log("OnEndDrag");
            canvasGroup.alpha = 1f; // return to normal when released
            canvasGroup.blocksRaycasts = true; // turn on the raycast
            CC.CheckC();
            CC.IsAnchor();
        }
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        //Debug.Log("OnPointerDown");
        //canDrag = false;

    }

    public void OnDrop(PointerEventData eventData)
    {
        canDrag = false;
        throw new System.NotImplementedException();
    }
}

