using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

[RequireComponent(typeof(Image), typeof(Button))]
public class CountryButton : MonoBehaviour
{
    public string countryName;

    void Awake()
    {
        // Ensure only visible pixels are clickable
        Image img = GetComponent<Image>();
        img.alphaHitTestMinimumThreshold = 0.5f;

        // Auto-assign country name if not set
        if (string.IsNullOrEmpty(countryName) && img.sprite != null)
        {
            countryName = img.sprite.name;
        }
    }
}
