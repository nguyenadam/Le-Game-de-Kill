using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // public string name; <-- turns out this already exists, cause like yk, every object in unity has a name field.
    public string description;
    public int weight; // ounces
    public int size; // cube inches
    public string category;
    public ArrayList tags = new ArrayList();
    public bool menuOpen = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnGUI()
    {
        if (menuOpen)
        {
            var text = name;
            var position = Camera.main.WorldToScreenPoint(gameObject.transform.position);
            var textSize = GUI.skin.label.CalcSize(new GUIContent(text)) + new Vector2(10, 0);
            GUI.Box(new Rect(position.x - textSize.x / 2, Screen.height - position.y + textSize.y / 2, textSize.x, textSize.y), text);
        }
    }
}
