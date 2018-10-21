using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCard : MonoBehaviour {

    [SerializeField] private SceneController controller;
    [SerializeField] private GameObject BackCard;

    public void OnMouseDown()
    {

        if (BackCard.activeSelf && controller.caReveal)
        {
            BackCard.SetActive(false);
            controller.CardRevealed(this);

        }
    }

    private int _id;
    public int id

    {
        get { return _id;}
    }

    public void ChangeSprite(int id, Sprite img)
    {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = img;
    
    }

    public void Unrevealed(){
        BackCard.SetActive(true);
    }
}
