using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerManager : MonoBehaviour
{
    public static playerManager playerInstance;
    public deckScript playerDeckObject;
    public List<cardData> playerDeck;
    public handScript playerHand;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void drawCard(int cardsToDraw){
        var children = playerDeckObject.gameObject.GetComponentsInChildren<cardObject>();
        if (cardsToDraw > 0){
            if (cardsToDraw <= children.Length){
                for(var i=0; i<cardsToDraw; i++){
                    children[i].transform.SetParent(playerHand.gameObject.transform, false);
                    children[i].transform.rotation = playerHand.transform.rotation;
                    children[i].flipCard();
                    
                }
            }else{
                Debug.Log("Warning: Trying to draw more cards than there are in the deck.");
            }

        }else{
            Debug.Log("Error: Cannot draw the requested number of cards.");
        }
    }
}
