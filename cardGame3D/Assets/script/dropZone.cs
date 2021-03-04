using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class dropZone : MonoBehaviour, IDropHandler, IPointerEnterHandler, IPointerExitHandler{

    public GameObject cameraOne;
    public GameObject cameraTwo;
    public fieldScript playerField;

    public void OnPointerEnter(PointerEventData eventData){
//        Debug.Log("pointer entered");
    }

    public void OnPointerExit(PointerEventData eventData){
//        Debug.Log("pointer exit");
    }

    public void OnDrop(PointerEventData eventData){
        Debug.Log("Attempting to play card " + eventData.pointerDrag.name);
        cameraTwo.SetActive(true);
        cameraOne.SetActive(false);
        selectZone(eventData.pointerDrag);
        // change display to display 2 and have user select one of the positions.
    }

    public void selectZone(GameObject card){
        playerField.playingCard = true;
        playerField.cardToPlay = card;
    }
}
