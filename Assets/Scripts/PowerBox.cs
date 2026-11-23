using UnityEngine;
using Unity.VisualScripting;
using System;

public class PowerBox : MonoBehaviour
{    
    [SerializeField] private GameObject light1;
    [SerializeField] private GameObject light2;
    [SerializeField] private GameObject light3;
    [SerializeField] private GameObject light4;

    [SerializeField] private NPCInteract Interact;


    private PickupCollect pickup;
    public bool isPoweredOn = false;

    private string[] hintMessage = new string[2];

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {    
        light1.SetActive(false);
        light2.SetActive(false);
        light3.SetActive(false);
        light4.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PowerOn()
    {
            if (PickupCollect.pickupAmount >= 4)
            {
                light1.SetActive(true);
                light2.SetActive(true);
                light3.SetActive(true);
                light4.SetActive(true);

                PickupCollect.pickupAmount = 0; // Reset the pickup amount after powering on
                Interact.enabled = false; // Disable the NPCInteract script to prevent further interaction
                isPoweredOn = true;

                Interact.dialogueLines[0] = "That must have powered it on!";
                Interact.dialogueLines[1] = "Now I can pull the lever to use the crane! It should be at the top.";
            }
            else if (PickupCollect.pickupAmount >= 1 && PickupCollect.pickupAmount < 4)
            {
                Interact.dialogueLines[0] = "I need more power to get this working.";
                Interact.dialogueLines[1] = "I should look around a little bit more.";
            }
            else if (PickupCollect.pickupAmount == 0)
            {
                Interact.dialogueLines[0] = "It looks like this needs power.";
                Interact.dialogueLines[1] = "Maybe I can find something around here.";
            }
    }
}