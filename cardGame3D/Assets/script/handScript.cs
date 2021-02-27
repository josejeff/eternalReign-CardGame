using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class handScript : MonoBehaviour
{
    [SerializeField] private List<cardData> handList;
    [SerializeField] private GameObject card;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void UpdateHand()
    {
        clearHand();
       for (int i=0; i< handList.Count; i++){
            var cardObject = Instantiate(card);
            cardObject.transform.parent = gameObject.transform;
            var cardData = cardObject.GetComponent<cardObject>();
            cardData.cardData = handList[i];
        }
    }

    void clearHand(){
        var children = this.gameObject.GetComponentsInChildren<Transform>();
        foreach(Transform child in children){
            GameObject.Destroy(child.gameObject);
        }

    }

}
