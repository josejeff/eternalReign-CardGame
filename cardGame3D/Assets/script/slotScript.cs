using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class slotScript : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Sprite baseImage;
    public Sprite selectedImage;
    public cardObject playedCard;
    private Image slotImage;

    public void Start(){
        playedCard = null;
        slotImage = GetComponent<Image>();
    }

    public void OnPointerEnter(PointerEventData eventData){
        slotImage.sprite = selectedImage;
    }

    public void OnPointerExit(PointerEventData eventData){
        slotImage.sprite = baseImage;
    }

    public void OnPointerClick(PointerEventData eventData){
                //Use this to tell when the user left-clicks on the Button
        if (eventData.button == PointerEventData.InputButton.Left && slotImage.sprite == selectedImage && playedCard == null)
        {
            fieldScript parentObject = transform.parent.GetComponent<fieldScript>();
            GameObject card = parentObject.cardToPlay;
            card.transform.SetParent(this.transform);
            parentObject.cardToPlay = null;
            card.transform.localPosition = new Vector3(0, 20, 0);
            card.transform.rotation = this.transform.rotation;
            card.transform.localScale = new Vector3(0.5f,0.5f,1);

            parentObject.fieldCamera.SetActive(false);
            parentObject.playerCamera.SetActive(true);
        }
    }
}
