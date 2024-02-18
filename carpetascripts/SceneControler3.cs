using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneControler3 : MonoBehaviour
{
    public const int griRows = 2;
    public const int griCols = 7;
    public const float offsetX = 2.5f;
    public const float offsetY = 4f;

    [SerializeField] private CartaCompleta originalCard;
    [SerializeField] private Sprite[] images;

    public GameObject pantallaExito;

    public int score = 0;

    // Start is called before the first frame update
    private void Start()
    {
        pantallaExito.gameObject.SetActive(false);
        Vector3 startPos = originalCard.transform.position;
        int[] numbers = {0,0,1,1,2,2,3,3,4,4,5,5,6,6};
        numbers = ShuffleArray(numbers);

        for (int i = 0; i < griCols; i++)
        {
            for (int j = 0; j < griRows; j++)
            {
                CartaCompleta card;
                if (i == 0 && j ==0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as CartaCompleta;
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
        
        private CartaCompleta _firstReveaLed;
        private CartaCompleta _sconReveaLed;
        private int _score = 0;
        
        [SerializeField]private TextMesh scoreLabel;
        
        public bool canReveal
        {
            get { return _sconReveaLed = null; }
        }
        
        public void CardRevealed3(CartaCompleta card)
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
                if (_score == 7)
                {
                    Invoke ("SC3", 0.7f);
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

    void SC3()
    { 
        pantallaExito.SetActive(true);
    }
    

}