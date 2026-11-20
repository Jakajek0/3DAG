using UnityEngine;
using System.Collections;
using Unity.VisualScripting;

public class PowerBox : MonoBehaviour
{    
    [SerializeField] private GameObject light1;
    [SerializeField] private GameObject light2;
    [SerializeField] private GameObject light3;
    [SerializeField] private GameObject light4;

    private PickupCollect pickup;
    public bool moveLock = true;

    [SerializeField] private TextBox box;

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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (PickupCollect.pickupAmount == 4)
            {
                light1.SetActive(true);
                light2.SetActive(true);
                light3.SetActive(true);
                light4.SetActive(true);
            }
            else if (PickupCollect.pickupAmount == 3)
            {
                light1.SetActive(true);
                light2.SetActive(true);
                light3.SetActive(true);
            }
            else if (PickupCollect.pickupAmount == 2)
            {
                light1.SetActive(true);
                light2.SetActive(true);
            }
            else if (PickupCollect.pickupAmount == 1)
            {
                light1.SetActive(true);
            }

            StartCoroutine(HandleTriggerSequence());
        }
    }

    private IEnumerator HandleTriggerSequence()
    {
        moveLock = false;
        box.TextBoxOpen();
        
        yield return new WaitUntil(() => Input.GetMouseButtonDown(0)); 

        box.TextBoxClose();
        moveLock = true;
    }
}