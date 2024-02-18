using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using DG.Tweening;

public class CharacterShopUI : MonoBehaviour
{
	[Header ("Layout Settings")]

    [SerializeField] float itemSpacing = 1f;
    float itemHeight;


    [Header ("UI Elements")]

    [SerializeField] Image selectedJugueteIcon;
    [SerializeField] Transform shopMenu;
    [SerializeField] Transform ShopItemsContainer;
    [SerializeField] GameObject itemPrefab;
    [SerializeField] CharacterShopDatabase characterDB;

    [Header ("Shop Events")]

    [SerializeField] GameObject shopUI;
    [SerializeField] Button openShopButton;
    [SerializeField] Button closeShopButton;

    [Header ("Main Menu")]
    [SerializeField] Image mainMenuCharacterImage;
    [SerializeField] TMP_Text mainMenuRopaName;

    [Header ("Purchase & Message Error")]

    [SerializeField] Transform PurchaseFxPos;
    [SerializeField] TMP_Text NohaysuficientesMonedasTexto;

    [Header ("Scroll View")]
    [SerializeField] ScrollRect scrollrect;
    [SerializeField] GameObject TopScrollFade;
    [SerializeField] GameObject BottomScrollFade;
    [SerializeField] Button ScrollUpButton;




    int newSelectedItemIndex = 0;
    int previousSelectedItemIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        AddShopEvents ();
        GenerateShopItemsUI();
        SetSelectedCharacter();
        SelectItemUI (Neuro.GetSelectedCharacterIndex());
        ChangeNeuroSkin();
        AutoScrollList(Neuro.GetSelectedCharacterIndex());

        
    }

    void AutoScrollList(int itemIndex)
    {
        scrollrect.horizontalNormalizedPosition = Mathf.Clamp01(1f - (itemIndex/(float)(characterDB.CharactersCount -1)));

    }

    void SetSelectedCharacter()
    {
        int index = Neuro.GetSelectedCharacterIndex();
        Neuro.SetSelectedCharacter(characterDB.GetCharacter(index), index);
    }

    void GenerateShopItemsUI ()
	{	
		//Loop throw save purchased items and make them as purchased in the Database array
		for (int i = 0; i < Neuro.GetAllPurchasedCharacter ().Count; i++) {
			int purchasedCharacterIndex = Neuro.GetPurchasedCharacter (i);
			characterDB.PurchaseCharacter (purchasedCharacterIndex);
		}
		
		//Delete itemTemplate after calculating item's Height :
		itemHeight = ShopItemsContainer.GetChild (0).GetComponent <RectTransform> ().sizeDelta.y;
		Destroy (ShopItemsContainer.GetChild (0).gameObject);
		//DetachChildren () will make sure to delete it from the hierarchy, otherwise if you 
		//write ShopItemsContainer.ChildCount you w'll get "1"
		ShopItemsContainer.DetachChildren ();

		//Generate Items
		for (int i = 0; i < characterDB.CharactersCount; i++) {
			//Create a Character and its corresponding UI element (uiItem)
			Character character = characterDB.GetCharacter (i);
			CharacterItemUI uiItem = Instantiate (itemPrefab, ShopItemsContainer).GetComponent <CharacterItemUI> ();

			//Move item to its position
			uiItem.SetItemPosition (Vector2.right * i * (itemHeight + itemSpacing));

			//Set Item name in Hierarchy (Not required)
			uiItem.gameObject.name = "Item" + i + "-" + character.name;

			//Add information to the UI (one item)
			uiItem.SetCharacterName (character.name);
			uiItem.SetCharacterImage (character.image);
			
			uiItem.SetCharacterPrice (character.price);

			if (character.isPurchased) {
				//Character is Purchased
				uiItem.SetCharacterAsPurchased ();
				uiItem.OnItemSelect (i, OnItemSelected);
			} else {
				//Character is not Purchased yet
				uiItem.OnItemPurchase (i, OnItemPurchased);
			}

			//Resize Items Container
			ShopItemsContainer.GetComponent <RectTransform> ().sizeDelta = 
				Vector2.left * ((itemHeight + itemSpacing) * characterDB.CharactersCount + itemSpacing);

			//you can use VerticalLayoutGroup with ContentSizeFitter to skip all of this :
			//(moving items & resizing the container)
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
        return ShopItemsContainer.GetChild(index).GetComponent <CharacterItemUI> ();

    }

    void OnItemPurchased(int index)
    {
        Character character = characterDB.GetCharacter (index);
        CharacterItemUI uiItem = GetItemUI (index);

        if (Neuro.CanSpendCoins(character.price))
        {
            Neuro.SpendCoins (character.price);
            GameSharedUI.Instance.UpdateCoinsUIText ();

            characterDB.PurchaseCharacter (index);

            uiItem.SetCharacterAsPurchased();
            uiItem.OnItemSelect (index, OnItemSelected);
            Neuro.AddPurchasedCharacter (index);

        }
        else
        {
            AnimatedNoMoreCoinsText();
        }
    }

    void AnimatedNoMoreCoinsText()
    {
        NohaysuficientesMonedasTexto.DOComplete();
        NohaysuficientesMonedasTexto.transform.DOComplete();

        NohaysuficientesMonedasTexto.transform.DOShakePosition(3f,new Vector3(5f,0f,0f),10,0);
        NohaysuficientesMonedasTexto.DOFade(1f,3f).From (0f).OnComplete(() =>{
            NohaysuficientesMonedasTexto.DOFade (0f, 1f);
        });

    }
    

    void AddShopEvents()
    {
        openShopButton.onClick.RemoveAllListeners();
        openShopButton.onClick.AddListener(OpenShop);
        closeShopButton.onClick.RemoveAllListeners();
        closeShopButton.onClick.AddListener(CloseShop);
        scrollrect.onValueChanged.RemoveAllListeners();
        scrollrect.onValueChanged.AddListener(OnShopListScroll);
        ScrollUpButton.onClick.RemoveAllListeners();
        ScrollUpButton.onClick.AddListener(OnScrollUpClicked);
    }

    void OnScrollUpClicked()
    {
        scrollrect.DOHorizontalNormalizedPos (1f, .5f).SetEase (Ease.OutBack);
    }

    void OnShopListScroll(Vector2 value)
    {
        float ScrollX = value.x;

        if (ScrollX < 1f)
        TopScrollFade.SetActive (true);
        else
        TopScrollFade.SetActive (false);

        if (ScrollX > 0f)
        BottomScrollFade.SetActive (true);
        else
        BottomScrollFade.SetActive (false);

        if (ScrollX < .7f)
        ScrollUpButton.gameObject.SetActive(true);
        else
        ScrollUpButton.gameObject.SetActive(false);




    }

    void OpenShop ()
    {
        shopUI.SetActive (true);
    }

    void CloseShop ()
    {
        shopUI.SetActive (false);
        Debug.Log(Application.persistentDataPath+"/GameData/");
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}



