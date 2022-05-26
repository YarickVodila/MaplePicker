using System.Collections;
using UnityEngine;
// 1 - Start
using System.Collections.Generic;
using UnityEngine.SceneManagement;
// 1 - End

public class ApplePicker : MonoBehaviour
{
   // 2 - Start
    [Header("Set in Inspector")]
// 2 - End

    public GameObject basketPrefab;
    public int numBaskets = 3;
    public float basketButtomY = -2f;
    public float basketSpacingY = 2f;
// 3 - Start
    public List<GameObject> basketList;
// 3 - End

    void Start()
    {

    }

    public void AppleDestroyed()
    {
        GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Apple");
        foreach (GameObject tGO in tAppleArray)
        {
            Destroy(tGO);
        }
// 6 - Start
        int basketIndex = basketList.Count - 1;
        GameObject tBasketGo = basketList[basketIndex];
        basketList.RemoveAt(basketIndex);
        Destroy(tBasketGo);
		// 1 - Start
        if (basketList.Count == 0)
        {
            SceneManager.LoadScene("_Scene_0");
        }
// 1 - End
	}

}
