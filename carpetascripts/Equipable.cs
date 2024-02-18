using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Equipable : MonoBehaviour
{
    public static Equipable equipable;
    [SerializeField] Sprite Sombrero;
    [SerializeField] CharacterShopDatabase characterDB;
    // Start is called before the first frame update
    void Awake()
    {
        equipable = this;

    }

    void Start()
    {
        SetSelectedCharacter();
        
        Equipar();
        //SetSelectedCharacter();
        this.gameObject.GetComponent<SpriteRenderer>().sprite = Sombrero;

        
    }

    void SetSelectedCharacter ()
	{
        //Character character  = Neuro.GetSelectedCharacter ();
		//Get saved index
		int index = Neuro.GetSelectedCharacterIndex ();

		//Set selected character
		Neuro.SetSelectedCharacter (characterDB.GetCharacter (index), index);
	}

    void Equipar()
    {
        Character character  = Neuro.GetSelectedCharacter ();
        if (character.image != null)
        {
        Sombrero = Neuro.GetSelectedCharacter().image;
        Debug.Log("seleccionado");
        }
        
    }

    void Vestir()
    {
        Character character  = Neuro.GetSelectedCharacter ();
        if (character.isPurchased)
        {
            SetSelectedCharacter();
        }
    }
}
