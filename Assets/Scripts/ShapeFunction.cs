using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ShapeFunction : NewShape
{
    public string ShapeName;
    public string ShapeColor;

    public override void DisplayText()
    {   
        shapeName.text = "Shape Name: " + ShapeName;
        shapeColor.text = "Shape Color: " + ShapeColor;
    }
}
