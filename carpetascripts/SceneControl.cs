using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControl : MonoBehaviour
{
    public const int griRows = 2;
    public const int griCols = 4;
    public const float offsetX = 4f;
    public const float offsetY = 4f;

    [SerializeField] private CartaTutorial2 originalCard;
    [SerializeField] private Sprite[] images;

    public GameObject pantallaExito;

    public int score = 0;

    // Start is called before the first frame update
    private void Start()
    {
        pantallaExito.gameObject.SetActive(false);
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = {0,0,1,1,2,2,3,3};
        numbers = ShuffleArray(numbers);

        for (int i = 0; i < griCols; i++)
        {
            for (int j = 0; j < griRows; j++)
            {
                CartaTutorial2 card;
                if (i == 0 && j ==0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as CartaTutorial2;
                }
                
                int index = j * griCols + i;
                int id = numbers[index];
                card.ChangeSprite(id, images[id]);
                
                float posX = (offsetX * i) + startPos.x;
                float posY = (offsetY* j) + startPos.y;
                card.transform.position = new Vector3(posX, posY, startPos.z);
                }
            }
        }
        private int[] ShuffleArray(int[] numbers)
        {
            int[] newArray = numbers.Clone() as int[];
            for (int i = 0; i < newArray.Length; i++)
            {
                int tmp = newArray[i];
                int r = Random.Range(i, newArray.Length);
                newArray[i] = newArray[r];
                newArray[r] = tmp;
            }
            return newArray;
        }
        
        private CartaTutorial2 _firstReveaLed;
        private CartaTutorial2 _sconReveaLed;
        private int _score = 0;
        
        [SerializeField]private TextMesh scoreLabel;
        
        public bool canReveal
        {
            get { return _sconReveaLed = null; }
        }
        
        public void CardRevealed(CartaTutorial2 card)
        {
            if(_firstReveaLed == null)
            {
                _firstReveaLed = card;
            }
            else
            {
                _sconReveaLed = card;
                StartCoroutine(CheckedMatch());
            }
        }
        
        private IEnumerator CheckedMatch()
        {
            if (_firstReveaLed.id == _sconReveaLed.id)
            {
                _score++;
                scoreLabel.text = "Score: " + _score;
                if (_score == 4)
                {
                    Invoke ("SC1", 0.7f);
                }
            }
            else
            {
                yield return new WaitForSeconds (0.1f);
                _firstReveaLed.Unreveal();
                _sconReveaLed.Unreveal();
            }
            _firstReveaLed = null;
            _sconReveaLed = null;
            }
        void cardCoparion(List<int> c)
        {
            
    }

    void SC1()
    { 
        pantallaExito.SetActive(true);
    }
    

}