using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShoppingList : MonoBehaviour
{
    public Text textName;

    public GameObject textField;

    public GameObject vareFelt;

    // Start is called before the first frame update
   public void LavNyVare(string input)
   {
       GameObject newTextField = Instantiate(textField, Vector3.zero, Quaternion.identity, transform);
  
       Text newTextFieldText = newTextField.GetComponent<Text>();
       newTextFieldText.text = input;
  
       RectTransform rect = newTextField.GetComponent<RectTransform>();
       rect.anchoredPosition = new Vector2(0, 0);


       vareFelt.transform.SetAsLastSibling();
  
   }


}
