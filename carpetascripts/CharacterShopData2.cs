using UnityEngine;

[CreateAssetMenu (fileName = "CharacterShopDatabase2", menuName = "Shopping/Characters shop database2")]
public class CharacterShopData2 : ScriptableObject
{
	public Character2[] characters2;

	public int CharactersCount2 {
		get{ return characters2.Length; }
	}

	public Character2 GetCharacter2 (int index)
	{
		return characters2 [index];
	}

	public void PurchaseCharacter2 (int index)
	{
		characters2 [index].isPurchased2 = true;
	}
}
