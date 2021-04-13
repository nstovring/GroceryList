using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShoppingListManager : MonoBehaviour
{
    public GameObject textField;

    public GameObject textfieldParent;

    public GameObject shoppingListPrefab;

    public GameObject canvas;

    //public List<RectTransform> items;

    public int textOffset = 0;

    // Start is called before the first frame update
    void Start()
    {
        //items = new List<RectTransform>();
    }


    public void TextReset(InputField f)
    {
        f.text = "";
    }


    public void DeleteButton(GameObject g)
    {
        Destroy(g);
    }


    public void LavNyVare(string input)
    {
        GameObject newTextField = Instantiate(textField, Vector3.zero, Quaternion.identity,textfieldParent.transform);

        Text newTextFieldText = newTextField.GetComponent<Text>();
        newTextFieldText.text = input;

        RectTransform rect = newTextField.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, textOffset);
        textOffset -= 20;

    }

    public void CreateList(string input)
    {
        GameObject newPanel = Instantiate(shoppingListPrefab, Vector3.zero, Quaternion.identity, canvas.transform);

        ShoppingList newList = newPanel.GetComponent<ShoppingList>();
        //newList.Name = input;

        newList.textName.text = input;
        RectTransform rect = newPanel.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, textOffset);
        textOffset -= 20;

    }
}
