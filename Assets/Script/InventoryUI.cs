using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    Inventory inven;
    public GameObject Inventorypanel;
    public Slot[] slots;
    public Transform slotHolder;
    bool InventoryOnOff = false;
    // Start is called before the first frame update
    void Start()
    {
        inven = Inventory.instance;
        slots = slotHolder.GetComponentsInChildren<Slot>();
        Inventorypanel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            InventoryOnOff = !InventoryOnOff;
            Inventorypanel.SetActive(InventoryOnOff);
        }

    }
}
