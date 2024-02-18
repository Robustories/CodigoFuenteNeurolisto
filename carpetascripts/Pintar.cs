using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Pintar : MonoBehaviour
{
    private Texture2D newTex;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if (!Input.GetMouseButton(0))
			return;

	RaycastHit hit;
	if (!Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
		return;

	SpriteRenderer renderer = this.GetComponent<SpriteRenderer>();
	Texture2D tex = renderer.sprite.texture;
	newTex = (Texture2D)GameObject.Instantiate(tex);
	Vector2 pixelUV = hit.textureCoord;
	pixelUV.x *= newTex.width;
	pixelUV.y *= newTex.height;
	pixelUV.x = newTex.width - pixelUV.x;
	pixelUV.y = newTex.height - pixelUV.y;

	Debug.Log(pixelUV.x+" "+pixelUV.y);

	//Color color = Camera.main.GetComponent<PaintGameScript>().paintColor;

	//newTex.FloodFillBorder((int)pixelUV.x, (int)pixelUV.y, color, Color.black);

//		for(int i = (int)pixelUV.x-10; i<(int)pixelUV.x+10; i++)
//			for(int j = (int)pixelUV.y-10; j<(int)pixelUV.y+10; j++)
//				newTex.SetPixel(i, j, Color.cyan);

	newTex.Apply();
	
	renderer.sprite = Sprite.Create(newTex, renderer.sprite.rect, new Vector2(0.5f, 0.5f), 5f);


    }
}
