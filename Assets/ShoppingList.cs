using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour
{
    public string Name;
    public List<string> items;

    public Text textName;
    public GameObject textInput;
    public GameObject textFieldPrefab;
    public GameObject textfieldParent;

    // Start is called before the first frame update
    public void AddToList(string input)
    {
        GameObject newTextField = Instantiate(textFieldPrefab, Vector3.zero, Quaternion.identity, transform);

        Text newTextFieldText = newTextField.GetComponent<Text>();
        newTextFieldText.text = input;

        items.Add(input);
    }
}
