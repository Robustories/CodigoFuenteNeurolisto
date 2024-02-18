using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ShopManager : MonoBehaviour
{
    public static ShopManager shopmanager;

    
    [SerializeField]
    
    private List<CharacterItemUI> ItemCompra2;
    private List<CharacterItemUI> itDesactivar2 = new List<CharacterItemUI>();
    private List<CharacterItemUI> itActivar2 = new List<CharacterItemUI>();
    private List<CharacterItemUI> ItemsVendidos = new List<CharacterItemUI>();
    [SerializeField] CharacterShopDatabase characterDB;
    
    [SerializeField]
    private ListaJuguetes LJ;
    public Transform contenedorItem;
    [Header("Carteles")]
    
    public GameObject insuficienteDinero;
    public GameObject shopUI;
    

    public static ShopManager instance = null;

    private GenericScript genericScript;

    int newSelectedItemIndex = 0;
    int previousSelectedItemIndex = 0;

    [SerializeField] Image mainMenuCharacterImage;
    [SerializeField] TMP_Text mainMenuRopaName;

    [SerializeField] Image selectedJugueteIcon;
    
    [SerializeField] GameObject itemPrefab;

    [SerializeField] Button openShopButton;
    [SerializeField] Button closeShopButton;

   

  
    



    


    // Start is called before the first frame update
    void Start()
    {
        AddShopEvents();

        GenerateShopItemsUI ();

        //SetSelectedCharacter ();

        //SelectItemUI (Neuro.GetSelectedCharacterIndex ());

        ChangeNeuroSkin ();

        

        
        
        insuficienteDinero.SetActive(false);
        
    }

    void SetSelectedCharacter ()
	{
		//Get saved index
		int index = Neuro.GetSelectedCharacterIndex ();

		//Set selected character
		Neuro.SetSelectedCharacter (characterDB.GetCharacter (index), index);
	}

    void GenerateShopItemsUI ()
	{
        

        for (int i = 0; i < Neuro.GetAllPurchasedCharacter ().Count; i++) {
			int purchasedCharacterIndex = Neuro.GetPurchasedCharacter (i);
			characterDB.PurchaseCharacter (purchasedCharacterIndex);
		}

        Destroy (contenedorItem.GetChild (0).gameObject); 
        //contenedorItem.DetachChildren ();

        //ItemCompra2 = new List<CharacterItemUI >();
        for (int i = 0; i < characterDB.CharactersCount; i++)
        {
            Character character = characterDB.GetCharacter (i);
            CharacterItemUI uiItem = Instantiate (itemPrefab, contenedorItem).GetComponent <CharacterItemUI> ();
            //ItemCompra2.Add(contenedorItem.transform.GetChild(i).GetComponent<CharacterItemUI >());

            

            

            uiItem.gameObject.name = "Item" + i + "-" + character.name;
            uiItem.SetCharacterName (character.name);
			uiItem.SetCharacterImage (character.image);
			
			uiItem.SetCharacterPrice (character.price);

            if (character.isPurchased) {
				//Character is Purchased
				uiItem.SetCharacterAsPurchased ();
				uiItem.OnItemSelect (i, OnItemSelected);
			} else {
				//Character is not Purchased yet
				uiItem.OnItemPurchase (i, ComprarItem);
			}

            
        }
    }

    void ChangeNeuroSkin()
    {
        Character character  = Neuro.GetSelectedCharacter ();
        if (character.image != null)
        {
            mainMenuCharacterImage.sprite = character.image;
            mainMenuRopaName.text = character.name;

            selectedJugueteIcon.sprite = Neuro.GetSelectedCharacter().image;

        }

        
    }

    void OnItemSelected(int index)
    {
        SelectItemUI(index);


        Neuro.SetSelectedCharacter (characterDB.GetCharacter (index), index);

        ChangeNeuroSkin();
        
    
    }

    void SelectItemUI(int itemIndex)
    {
        previousSelectedItemIndex = newSelectedItemIndex;
        newSelectedItemIndex = itemIndex;

        CharacterItemUI prevUiItem = GetItemUI( previousSelectedItemIndex);
        CharacterItemUI newUiItem = GetItemUI( newSelectedItemIndex);

        prevUiItem.DeselectItem();
        newUiItem.SelectItem();

    }

    CharacterItemUI GetItemUI(int index)
    {
        return contenedorItem.GetChild(index).GetComponent <CharacterItemUI> ();

    }

    public void ComprarItem(int index)
    //void ComprarItem(int itemID)
    {
        Character character = characterDB.GetCharacter (index);
        CharacterItemUI uiItem = GetItemUI (index);

        if (Neuro.CanSpendCoins(character.price))
        {
            Debug.Log("Item Tienda Comprado");
            Neuro.SpendCoins (character.price);
            GameSharedUI.Instance.UpdateCoinsUIText ();

            characterDB.PurchaseCharacter (index);

            uiItem.SetCharacterAsPurchased();
            uiItem.OnItemSelect (index, OnItemSelected);
            Neuro.AddPurchasedCharacter (index);
            

        }
            
        else
        {
            insuficienteDinero.SetActive(true);
        }

    

    }


    void AddShopEvents()
    {
        openShopButton.onClick.RemoveAllListeners();
        openShopButton.onClick.AddListener(OpenShop);
        closeShopButton.onClick.RemoveAllListeners();
        closeShopButton.onClick.AddListener(CloseShop);
    }

    public void OpenShop ()
    {
        shopUI.SetActive (true);
    }

    public void CloseShop ()
    {
        shopUI.SetActive (false);
    }

    
    
}

