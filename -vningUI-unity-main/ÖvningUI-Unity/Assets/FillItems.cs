using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FillItems : MonoBehaviour
{

    public GameObject itemHolder;
    public GameObject textprefab;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject text = Instantiate(textprefab);
            RectTransform rectTransform = text.GetComponent<RectTransform>();

            rectTransform.anchoredPosition = new Vector2(30, 50 * i);
            text.transform.SetParent(itemHolder.transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
