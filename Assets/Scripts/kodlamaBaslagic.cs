using UnityEngine;

public class kodlamaBaslagic : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    string deneme = "Unity";
    
    void Start()
    {
        string spacedText = string.Join(" ", deneme.ToCharArray());
        Debug.Log(spacedText);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
