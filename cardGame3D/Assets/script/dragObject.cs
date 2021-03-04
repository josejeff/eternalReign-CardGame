using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dragObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    Transform parentToReturnTo = null;
    Vector3 cardPosition;
    public Vector2 difference;
    private int siblingIndex = 0;

    public void OnBeginDrag(PointerEventData eventData){
        if(this.transform.parent.name == "playerHand"){
            parentToReturnTo = this.transform.parent;
            cardPosition = this.transform.position;
            GetComponent<CanvasGroup>().blocksRaycasts = false;
            siblingIndex = this.transform.GetSiblingIndex();
            this.transform.SetParent(this.transform.parent.parent);
        }
    }

    public void OnDrag(PointerEventData eventData){
//      Debug.Log("dragging");
        if(this.transform.parent.name == "Player View"){
            Debug.Log(eventData.position);
            this.transform.localPosition = eventData.position - difference;
        }
    }

    public void OnEndDrag(PointerEventData eventData){
        this.transform.SetParent(parentToReturnTo);
        this.transform.SetSiblingIndex(siblingIndex);
        this.transform.position = cardPosition;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
//        Debug.Log("Finished dragging");
    }

}
