using Shapes2D;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptableShape : ScriptableObject {

    public Shape shape;

    public void setTypeShape(ShapeType type)
    {
        shape.settings.shapeType = type;
    }


}