using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class ShopManager2 : MonoBehaviour
{
    public static ShopManager2 shopmanager2;

    
    [SerializeField]
    
    private List<CharacterItemUI> ItemCompra22;
    private List<CharacterItemUI> itDesactivar2 = new List<CharacterItemUI>();
    private List<CharacterItemUI> itActivar2 = new List<CharacterItemUI>();
    private List<CharacterItemUI> ItemsVendidos = new List<CharacterItemUI>();
    
    [SerializeField] CharacterShopData2 characterDB2;
    
    
    public Transform contenedorItem2;
    [Header("Carteles")]
    
    public GameObject insuficienteDinero2;
    public GameObject shopUI2;
    

    public static ShopManager2 instance2 = null;

    private GenericScript genericScript2;

    int newSelectedItemIndex2 = 0;
    int previousSelectedItemIndex2 = 0;

    [SerializeField] Image mainMenuCharacterImage2;
    [SerializeField] TMP_Text mainMenuRopaName2;

    [SerializeField] Image selectedJugueteIcon2;
    
    [SerializeField] GameObject itemPrefab2;

    [SerializeField] Button openShopButton2;
    [SerializeField] Button closeShopButton2;

   

  
    



    


    // Start is called before the first frame update
    void Start()
    {
        AddShopEvents();
        Destroy (contenedorItem2.GetChild (0).gameObject); 
        

        for (int i = 0; i < Neuro.GetAllPurchasedCharacter2 ().Count; i++) {
			int purchasedCharacterIndex2 = Neuro.GetPurchasedCharacter2 (i);
			characterDB2.PurchaseCharacter2 (purchasedCharacterIndex2);
		}

        //ItemCompra22 = new List<CharacterItemUI >();
        for (int i = 0; i < characterDB2.CharactersCount2; i++)
        {
            Character2 character2 = characterDB2.GetCharacter2 (i);
            CharacterItemUI uiItem = Instantiate (itemPrefab2, contenedorItem2).GetComponent <CharacterItemUI> ();
            //ItemCompra22.Add(contenedorItem2.transform.GetChild(i).GetComponent<CharacterItemUI >());

            

            

            uiItem.gameObject.name = "Item" + i + "-" + character2.name2;
            uiItem.SetCharacterName (character2.name2);
			uiItem.SetCharacterImage (character2.image2);
			
			uiItem.SetCharacterPrice (character2.price2);

            if (character2.isPurchased2) {
				//Character is Purchased
				uiItem.SetCharacterAsPurchased ();
				uiItem.OnItemSelect (i, OnItemSelected2);
			} else {
				//Character is not Purchased yet
				uiItem.OnItemPurchase (i, ComprarItem);
			}

            
        }

        
        
        insuficienteDinero2.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ChangeNeuroSkin2()
    {
        Character2 character2  = Neuro.GetSelectedCharacter2 ();
        if (character2.image2 != null)
        {
            mainMenuCharacterImage2.sprite = character2.image2;
            mainMenuRopaName2.text = character2.name2;

            selectedJugueteIcon2.sprite = Neuro.GetSelectedCharacter2().image2;

        }

        
    }

    void OnItemSelected2(int index)
    {
        SelectItemUI2(index);

        

        

        Neuro.SetSelectedCharacter2 (characterDB2.GetCharacter2 (index), index);

        ChangeNeuroSkin2();
        
    
    }

    void SelectItemUI2(int itemIndex)
    {
        previousSelectedItemIndex2 = newSelectedItemIndex2;
        newSelectedItemIndex2 = itemIndex;

        CharacterItemUI prevUiItem = GetItemUI( previousSelectedItemIndex2);
        CharacterItemUI newUiItem = GetItemUI( newSelectedItemIndex2);

        prevUiItem.DeselectItem();
        newUiItem.SelectItem();

    }

    CharacterItemUI GetItemUI(int index)
    {
        return contenedorItem2.GetChild(index).GetComponent <CharacterItemUI> ();

    }

    //public void ComprarItem(GameObject itemObject, int itemID, string itemType, string itemDescripcion, Sprite itemIcon)
    public void ComprarItem(int index)
    //void ComprarItem(int itemID)
    {
        Character2 character2 = characterDB2.GetCharacter2 (index);
        CharacterItemUI uiItem = GetItemUI (index);

        if (Neuro.CanSpendCoins(character2.price2))
        {
            Debug.Log("Item Tienda Comprado");
            Neuro.SpendCoins (character2.price2);
            GameSharedUI.Instance.UpdateCoinsUIText ();

            characterDB2.PurchaseCharacter2 (index);

            uiItem.SetCharacterAsPurchased();
            uiItem.OnItemSelect (index, OnItemSelected2);
            Neuro.AddPurchasedCharacter2 (index);
            

        }
            
        else
        {
            insuficienteDinero2.SetActive(true);
        }

    

    }

    void AddShopEvents()
    {
        openShopButton2.onClick.RemoveAllListeners();
        openShopButton2.onClick.AddListener(OpenShop2);
        closeShopButton2.onClick.RemoveAllListeners();
        closeShopButton2.onClick.AddListener(CloseShop2);
    }

    public void OpenShop2 ()
    {
        shopUI2.SetActive (true);
    }

    public void CloseShop2 ()
    {
        shopUI2.SetActive (false);
    }

    
    
}
