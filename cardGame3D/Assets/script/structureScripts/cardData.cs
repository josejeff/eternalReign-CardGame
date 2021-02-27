using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName="New Card", menuName = "Card")]
public class cardData : ScriptableObject{

    public string name;
    public string description;
    public string type;
    public Sprite artwork;

    public int cost;
    public int attack;
    public int defense;
    public List<string> effects;

    public void print(){
        Debug.Log(name + ":" + description + ", Card cost:" + cost);
    }
}
