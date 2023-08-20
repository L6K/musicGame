using UnityEngine;
using UnityEngine.UI;

public class SelectImage : MonoBehaviour
{
    public Text targetText;

    private Image imageComponent;

    private void Start()
    {
        imageComponent = GetComponent<Image>();
        string spriteName = targetText.text;
        Debug.Log(spriteName);

        Sprite loadedSprite = Resources.Load<Sprite>("img/" + spriteName);

        if (loadedSprite != null)
        {
            Debug.Log("exist");
            imageComponent.sprite = loadedSprite;
        }
        else
        {
            Debug.Log("non");
            Debug.LogError("Sprite not found: " + spriteName);
        }
    }

    public void LoadSpriteBasedOnText()
    {
        string spriteName = targetText.text;
        Debug.Log(spriteName);

        Sprite loadedSprite = Resources.Load<Sprite>("img/" + spriteName);

        if (loadedSprite != null) 
        {
            Debug.Log("exist");
            imageComponent.sprite = loadedSprite;
        }
        else
        {
            Debug.Log("non");
            Debug.LogError("Sprite not found: " + spriteName);
        }
    }
}





