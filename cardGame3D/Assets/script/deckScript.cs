using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deckScript : MonoBehaviour
{
    [SerializeField] private List<cardData> deckList;
    [SerializeField] private GameObject card;

    void Awake(){
        for (int i=0; i< deckList.Count; i++){
            Vector3 pos = transform.position + new Vector3(0,-i*1,0);
            var cardObject = Instantiate(card, pos, gameObject.transform.rotation);
            cardObject.transform.parent = gameObject.transform;
            var cardData = cardObject.GetComponent<cardObject>();
            cardData.cardData = deckList[i];
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
