using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class NewShape : MonoBehaviour
{
    public TextMeshProUGUI shapeName; 
    public TextMeshProUGUI shapeColor;

    string shapeNameText;
    string shapeColorText;

    private void Start()
    {
        shapeNameText = "No has seleccionado ninguna figura.";
        shapeColorText = "No hay figuras seleccionadas.";
    }

    private void OnMouseDown()
    {
        DisplayText();
    }

    public virtual void DisplayText()
    {
        shapeName.text = "Shape Name: " + shapeNameText;
        shapeColor.text = "Shape Color: " + shapeColorText;
    }
}
