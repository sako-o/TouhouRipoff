using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Anim : MonoBehaviour
{
    public float fadeSpeed;
    private Image image;
    private float targetAlpha;

    // https://stackoverflow.com/questions/56516299/how-to-fade-in-ui-image-in-unity
    // Start is called before the first frame update
    void Start()
    {
      image = GetComponent<Image>(); 
      Material clonedMaterial = Instantiate<Material>(image.material);
    
    IEnumerator FadeIn() {
    targetAlpha = 1.0f;
    Color curColor = image.color;
    while(Mathf.Abs(curColor.a - targetAlpha) > 0.0001f) {
        Debug.Log(image.material.color.a);
        curColor.a = Mathf.Lerp(curColor.a, targetAlpha, fadeSpeed * Time.deltaTime);
        image.color = curColor;
        yield return null;
        }
    }
      
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
