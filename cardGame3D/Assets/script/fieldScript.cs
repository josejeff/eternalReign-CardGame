using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class fieldScript : MonoBehaviour
{
    public slotScript zeroTop;
    public slotScript zeroMid;
    public slotScript zeroBot;
    public slotScript oneTop;
    public slotScript oneMid;
    public slotScript oneBot;
    public slotScript twoTop;
    public slotScript twoMid;
    public slotScript twoBot;
    public slotScript threeTop;
    public slotScript threeMid;
    public slotScript threeBot;
    public slotScript fourTop;
    public slotScript fourMid;
    public slotScript fourBot;

    public GameObject fieldCamera;
    public GameObject playerCamera;
    public bool playingCard;
    public bool updatedSlots;
    public GameObject cardToPlay;

    // Start is called before the first frame update
    void Start()
    {
        updatedSlots = false;
        playingCard = false;

        zeroTop.enabled = false;
        zeroMid.enabled = false;
        zeroBot.enabled = false;
        oneTop.enabled = false;
        oneMid.enabled = false;
        oneBot.enabled = false;
        twoTop.enabled = false;
        twoMid.enabled = false;
        twoBot.enabled = false;
        threeTop.enabled = false;
        threeMid.enabled = false;
        threeBot.enabled = false;
        fourTop.enabled = false;
        fourMid.enabled = false;
        fourBot.enabled = false;
        Cursor.visible = true;

    }

    // Update is called once per frame
    void Update()
    {
        if( fieldCamera.active){
            if (playingCard && !updatedSlots){
                updatedSlots = true;
                zeroTop.enabled = true;
                zeroMid.enabled = true;
                zeroBot.enabled = true;
                oneTop.enabled = true;
                oneMid.enabled = true;
                oneBot.enabled = true;
                twoTop.enabled = true;
                twoMid.enabled = true;
                twoBot.enabled = true;
                threeTop.enabled = true;
                threeMid.enabled = true;
                threeBot.enabled = true;
                fourTop.enabled = true;
                fourMid.enabled = true;
                fourBot.enabled = true;
            }
        }else{
            if(!playingCard && updatedSlots){
                updatedSlots = false;
                zeroTop.enabled = false;
                zeroMid.enabled = false;
                zeroBot.enabled = false;
                oneTop.enabled = false;
                oneMid.enabled = false;
                oneBot.enabled = false;
                twoTop.enabled = false;
                twoMid.enabled = false;
                twoBot.enabled = false;
                threeTop.enabled = false;
                threeMid.enabled = false;
                threeBot.enabled = false;
                fourTop.enabled = false;
                fourMid.enabled = false;
                fourBot.enabled = false;
            }
        }

    updatedSlots = playingCard;
    }



}
