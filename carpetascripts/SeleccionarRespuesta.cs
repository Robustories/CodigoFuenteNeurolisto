using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
[RequireComponent(typeof(Button))]
[RequireComponent(typeof(Image))]


public class SeleccionarRespuesta : MonoBehaviour
{
    private AudioSource theSound;
    private SpriteRenderer theSprite;
    //private bool isSelected = false;
    private Button m_button = null;
    private Image m_image = null;
    public Option Option { get; set;}
    private Color m_originalColor = Color.black;
    public List<Option> options = null;
    private Text m_text = null;
    

    // Start is called before the first frame update
    void Awake()
    {
        m_button = GetComponent<Button>();
        m_originalColor = m_image.color;

    }
    
    
    void Start()
    {
        theSprite = GetComponent<SpriteRenderer>();
        theSound = GetComponent<AudioSource>();
        
    }


    void OnMouseDown()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
        theSound.Play();
    }

    void OnMouseUp()
    {
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 0.5f);
        theSound.Stop();
    }

    public void Construct (Option option)
    {
       
        m_text.text = option.text;
        m_button.enabled = true;
        m_image.color = m_originalColor;


        Option = option; 

    }

    public void SetColor(Color c)
    {
        m_button.enabled = false;
        m_image.color = c;

    }

    
        

    

    public void pressed(BaseEventData eventData)
    {
        //isSelected = true;
        theSprite.color = new Color(theSprite.color.r, theSprite.color.g, theSprite.color.b, 1f);
    }

    public void notpressed(BaseEventData eventData)
    {
        //isSelected = false;
    }

    

    


}
