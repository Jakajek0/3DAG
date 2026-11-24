using UnityEngine;
using UnityEngine.UI;

public class SwissCollect : MonoBehaviour
{
    [SerializeField] Sprite swiss;
    [SerializeField] Sprite swisscollected;
    
    [SerializeField] GameObject swissObject;
    
    public static Image swissHud;

    public static bool swissCollected = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the GameObject
        swissHud = gameObject.GetComponentInChildren<Image>();

        swissCollected = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (swissCollected)
        {
            swissHud.sprite = swisscollected;

            swissHud.enabled = true;

            swissObject.SetActive(false);
        }
        else
        {
            swissHud.sprite = swiss;
            
            swissObject.SetActive(true);
        }
    }
}
