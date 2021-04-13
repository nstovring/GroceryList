using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShoppingListManager : MonoBehaviour
{

    public GameObject panel;
    public GameObject canvas;

    public GameObject textField;

    public GameObject textfieldParent;


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
        Debug.Log(input);

        GameObject newTextField = Instantiate(textField, Vector3.zero, Quaternion.identity, textfieldParent.transform);

        Text newTextFieldText = newTextField.GetComponent<Text>();
        newTextFieldText.text = input;

        RectTransform rect = newTextField.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, textOffset);
        textOffset -= 20;
    }

    public void LavNyListe(string navn)
    {

        GameObject newTextField = Instantiate(panel, Vector3.zero, Quaternion.identity, canvas.transform);

        ShoppingList newTextFieldText = newTextField.GetComponent<ShoppingList>();
        newTextFieldText.Name.text = navn;

        RectTransform rect = newTextField.GetComponent<RectTransform>();
        rect.anchoredPosition = new Vector2(0, textOffset);
        textOffset -= 20;

    }

    //public void RemoveItem(RectTransform item)
    //{
    //    items.Remove(item);
    //    UpdateItems();
    //    Destroy(item.gameObject);
    //}
    //
    //public void UpdateItems()
    //{
    //    textOffset = 0;
    //    for (int i = 0; i < items.Count; i++)
    //    {
    //        items[i].anchoredPosition = new Vector2(0, textOffset);
    //        textOffset -= 20;
    //    }
    //}
}
