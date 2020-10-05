using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    // public string name; <-- turns out this already exists, cause like yk, every object in unity has a name field.
    public string description;
    public int weight; // ounces
    public int size; // cube inches
    public ArrayList tags = new ArrayList();

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
