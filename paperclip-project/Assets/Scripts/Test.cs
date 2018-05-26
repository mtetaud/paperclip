using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Shapes2D;

public class Test : MonoBehaviour
{
    
    Shape objettest;
    
    public int numberOfShape;
    int numberOfShapeCnt;
    Vector3 temp = new Vector3(1, 0, 0);


    void OnGUI()
    {
        int w = Screen.width, h = Screen.height;
        GUIStyle style = new GUIStyle();
        Rect rect = new Rect(10, h - h * 2 / 100 - 10, w, h * 2 / 100);
        style.alignment = TextAnchor.UpperLeft;
        style.fontSize = h * 2 / 100;
        style.normal.textColor = Color.white;

        GUI.Box(new Rect(0, 0, 300, 400), "POUR CREER: Appuyer sur A; \nPour déplacer: A, \nPour supprimer :B");
        
    }

    // Use this for initialization
    void Start()
    {
        numberOfShapeCnt = 0;
        


    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (Input.GetKeyDown("a"))
        {
            if(numberOfShapeCnt<= numberOfShape) {
            print("hello world");
                Object Polygontest = Resources.Load("Shapes2D/Prefabs/Polygon");
                GameObject NewPolygon = (GameObject)GameObject.Instantiate(Polygontest, new Vector3(5, 0, 0), Quaternion.identity);
                NewPolygon.name = "AHAHA";
                //Shapes2D.Spawner.Instantiate(objettest);
                numberOfShapeCnt++;
            }
            else {
                GameObject.Find("AHAHA").transform.position -= temp;
                //print(objettest.GetType()); 
            }
            //myGameObject.transform.position += temp;
        };

        if (Input.GetKeyDown("b"))
        {
            numberOfShapeCnt = 0;
            print("goodbye world");
            Destroy(GameObject.Find("AHAHA"));

        }


    }
}
