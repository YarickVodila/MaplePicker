using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePhoto : MonoBehaviour
{
public Texture one;
public Texture[] mtex;
public Texture tow;
public int counter;
//public GameObject otchert;
public RawImage obImage;
//public Sprite[] Sprites;
// Start is called before the first frame update
void Start()
	{
		Invoke("changeMainImage", 3f);
		counter = 0;
	}

// Update is called once per frame
void Update()
	{
//delay(10000);

	}
public void changeMainImage()
	{
		if (counter == 5)
	{
		counter = 0;
	}
		obImage = this.GetComponent<RawImage>();
		obImage.texture = mtex[counter];
		counter += 1;

		Invoke("changeMainImage", 3f);
//GameObject.sprite = Sprites[imageIndex];
	}
}