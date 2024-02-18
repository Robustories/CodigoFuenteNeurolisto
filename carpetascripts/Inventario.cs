using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class Inventario : MonoBehaviour
{
    [System.Serializable]
    public struct ObjetoInvId
    {
        public int id;
    }

    [System.Serializable]
    public struct ItemSueltos
    {
        public int id;
    }

    [SerializeField]
    CharacterShopDatabase csd;
    public GraphicRaycaster graphRay;
    private PointerEventData pointerData;
    private List<RaycastResult> raycastResults;
    public static Transform canvas;
    public GameObject objetoSeleccionado;
    public Transform ExParent;

    [Header("Profs y items")]


    public static GameObject Descripcion;
    public int OSID;

    public Transform Contenido;
    public CharacterItemUI item;
    public List<ObjetoInvId> inventarios = new List<ObjetoInvId>();

    public Transform ItemSueltoRespawn;
    public Vector3 originalPos;

    public ShopManager shopManager;

    public bool inventaryEnabled;
    public GameObject inventory;
    private int allSlots;
    private int enabledSlots;
    private GameObject[] slot;
    public GameObject slotHolder;

    public static Inventario inventario1;

    private int items;

    // Start is called before the first frame update
   
    void Start()
    {
        inventory.gameObject.SetActive(false);

        originalPos = transform.parent.position;

        //InventoryUpdate();

        pointerData = new PointerEventData(null);
        raycastResults = new List<RaycastResult>();

        canvas = graphRay.transform;


        allSlots = slotHolder.transform.childCount;
        slot = new GameObject[allSlots];

        for (int i = 0; i < allSlots; i++)
        {
            slot[i] = slotHolder.transform.GetChild(i).gameObject;

        }

        
    }

    // Update is called once per frame
    void Update()
    {
        Arrastrar();
        
    }

    void Arrastrar()
    {
        if (Input.GetMouseButtonDown(1))
        {
            pointerData.position = Input.mousePosition;
            graphRay.Raycast(pointerData, raycastResults);
            if (raycastResults.Count > 0)
            {
                if(raycastResults[0].gameObject.GetComponent<CharacterItemUI>())
                {
                    objetoSeleccionado = raycastResults[0].gameObject;
                    ExParent = objetoSeleccionado.transform.parent;
                    ExParent.GetComponent<Image>().fillCenter = false;
                    objetoSeleccionado.transform.SetParent(canvas);
                }
            }
        }
        if (objetoSeleccionado != null)
        {
            //objetoSeleccionado.GetComponent<RectTransform>().localPosition = CanvasScreen(Input.mousePosition);

        }

        if (objetoSeleccionado != null)
        {
            if (Input.GetMouseButtonUp(0))
            {
                pointerData.position = Input.mousePosition;
                raycastResults.Clear();
                graphRay.Raycast(pointerData, raycastResults);
                objetoSeleccionado.transform.SetParent(ExParent);

                if (raycastResults.Count > 0)
                {
                    foreach (var resultado in raycastResults)
                    {
                        if (resultado.gameObject == objetoSeleccionado) continue;
                        if (resultado.gameObject.CompareTag("Slot"))
                        {
                            if (resultado.gameObject.GetComponentInChildren<CharacterItemUI>() == null)
                            {
                                objetoSeleccionado.transform.SetParent(resultado.gameObject.transform);
                                Debug.Log("Slot libre");
                            }
                        }
                        

                    }
                }
                objetoSeleccionado.transform.localPosition = Vector3.zero;
                objetoSeleccionado = null;

            }

        }
        raycastResults.Clear();
    }

    public void AbrirInventario()
    {
        inventory.SetActive(true);
        //inventaryEnabled = !inventaryEnabled;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag =="Item")
        {
            GameObject itemPickedUp = other.gameObject;

            CharacterItemUI item = itemPickedUp.GetComponent<CharacterItemUI>();

        }
    }

    List<CharacterItemUI> pool = new List<CharacterItemUI>();

    void InventoryUpdate()
    {
        for (int i = 0; i < pool.Count; i++)
        {
            if(i < inventarios.Count)
            {
                ObjetoInvId o = inventarios[i];
                
                pool[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                pool[i].itemButton.onClick.RemoveAllListeners();
                //pool[i].Boton.onClick.AddListener(() => gameObject.SendMessage(liju.baseDatos[o.id].Void, SendMessageOptions,DontRequireReceiver));
                pool[i].gameObject.SetActive(true);
            }
            else
            {
            pool[i].gameObject.SetActive(false);
            
            pool[i].gameObject.transform.parent.GetComponent<Image>().fillCenter = false;
            }
        }
        if(inventarios.Count > pool.Count)
        {
            for (int i = pool.Count; i < inventarios.Count; i++)
            {
                CharacterItemUI it = Instantiate(item, Contenido.GetChild(i));
                pool.Add(it);

                if(Contenido.GetChild(0).childCount >= 2)
                {
                    for(int s = 0; s < Contenido.childCount; s++)
                    {
                        if(Contenido.GetChild(s).childCount == 0)
                        {
                            it.transform.SetParent(Contenido.GetChild(s));
                            break;
                        }
                    }
                }

                it.transform.position = Vector3.zero;
                it.transform.localScale = Vector3.one;

                ObjetoInvId o = inventarios[i];
                
                
                pool[i].GetComponent<RectTransform>().localPosition = Vector3.zero;
                pool[i].itemButton.onClick.RemoveAllListeners();
                //pool[i].Boton.onClick.AddListener(() => gameObject.SendMessage(liju.baseDatos[o.id].Void, SendMessageOptions,DontRequireReceiver));
                pool[i].gameObject.SetActive(true);



            }

        }
    }
}
