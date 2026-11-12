using UnityEngine;
using UnityEngine.UI;

public class PickupCollect : MonoBehaviour
{
    // BatteryCollect collection logic
    public static int pickupAmount = 0;
    

    // Holds the images
    public static Image hud;

    // Battery sprites
    [SerializeField] Sprite pickup1Tex;
    [SerializeField] Sprite pickup2Tex;
    [SerializeField] Sprite pickup3Tex;
    [SerializeField] Sprite pickup4Tex;
    [SerializeField] Sprite pickup0Tex;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Find the GameObject
        hud = gameObject.GetComponentInChildren<Image>();

        // Hide the Image on Start
        hud.enabled = false;

        // Set initial pickup amount
        pickupAmount = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (pickupAmount == 1)
        {
            hud.sprite = pickup1Tex;

            hud.enabled = true;
        }
        else if (pickupAmount == 2)
        {
            hud.sprite = pickup2Tex;

            hud.enabled = true;
        }
        else if (pickupAmount == 3)
        {
            hud.sprite = pickup3Tex;

            hud.enabled = true;
        }
        else if (pickupAmount == 4)
        {
            hud.sprite = pickup4Tex;

            hud.enabled = true;
        }
        else
        {
            hud.sprite = pickup0Tex;
        }
    }
}
