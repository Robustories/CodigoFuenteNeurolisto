using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerControler : MonoBehaviour
{
    public Text scoretopoText;
    public int scoretopo;
    public int topoLimite;
    public GameObject pantallaBienTopo;
    public bool recover;
    


    private MoleSpawner ms;
    private Reloj re;
    // Start is called before the first frame update
    void Start()
    {
        scoretopo = 0;
        re = GetComponent<Reloj>();
        ms = GetComponent<MoleSpawner>();
        pantallaBienTopo.gameObject.SetActive(false);
        
        
    }

    // Update is called once per frame
    void Update()
    {
        if (recover == false){
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Vector2 mousePos2D = new Vector2(mousePos.x, mousePos.y);

            RaycastHit2D hit = Physics2D.Raycast(mousePos2D, Vector2.zero);
            if(hit.transform.gameObject != null)
            {
                scoretopo += 1;
                scoretopoText.text = scoretopo.ToString();
                //ms.Spawn();
                recover = true;
                Invoke ("TiempoMareado", 0.7f);

            }

        }

        if(topoLimite == scoretopo)
        {
            Debug.Log("You win");
            {Invoke ("GanarTopo", 0.7f); }             
        }
        }
        
    }

    void GanarTopo()
    { 
        pantallaBienTopo.SetActive(true);
    }

    void TiempoMareado()
    {
        recover = false;
    }

}
