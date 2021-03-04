using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class cardObject : MonoBehaviour
{
    public static cardObject activeCard;
    public cardData cardData;
    [SerializeField] private Text name;
    [SerializeField] private Text type;
    [SerializeField] private Text description;
    [SerializeField] private Text stats;
    [SerializeField] private Text cost;
    [SerializeField] private Image background;
    [SerializeField] private Sprite cardFront;
    [SerializeField] private Sprite cardBack;
    [SerializeField] private GameObject inHandUI;

    [SerializeField] private bool isFaceUp;
    private bool currentFace;


    // Start is called before the first frame update
    void Start(){
        background.sprite = cardBack;
        this.gameObject.name = "faceDownCard";
        this.name.text = "";
        this.type.text = "";
        this.description.text = "";
        this.stats.text =  "";
        this.cost.text = "";
        this.isFaceUp = false;
        this.currentFace = false;
        cardData.print();
    }

     // Update is called once per frame
    void Update(){
        // Used to let card know it needs to flip
        if (currentFace != isFaceUp){
            currentFace = isFaceUp;
            updateCardFace();
        }

        // Used to deselect currently active card
        if(Input.GetMouseButtonDown(1)){
            activeCard.inHandUI.SetActive(false);
        }
    }

    void updateCardFace(){
        if(isFaceUp){
            background.sprite = cardFront;
            this.gameObject.name = cardData.name;
            this.name.text = cardData.name;
            this.type.text = cardData.type;
            this.description.text = cardData.description;
            this.stats.text =  cardData.attack.ToString() + " / " + cardData.defense.ToString();
            this.cost.text = cardData.cost.ToString();
        }else{
            background.sprite = cardBack;
            this.gameObject.name = "faceDownCard";
            this.name.text = "";
            this.type.text = "";
            this.description.text = "";
            this.stats.text =  "";
            this.cost.text = "";

        }
    }
    
    public void flipCard(){
        isFaceUp = !isFaceUp;
    }

    public void enhanceView(){
        if(this.transform.parent.name == "playerHand"){
            this.transform.localScale = new Vector3(1.4f,1.4f,1);
        }
    }

    public void normalView(){
        if(this.transform.parent.name == "playerHand"){
            this.transform.localScale = new Vector3(1,1,1);
        }
    }
}
