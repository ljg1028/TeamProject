using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory instance;
   
    // Start is called before the first frame update
    private void Awake()
    {
        if(instance != null)
        {
            Destroy(gameObject);
            return;
        }
        instance = this;
    }
    public delegate void OnSlotCountChange(int val);
    public OnSlotCountChange onSlotCountChange;
    private int slotCnt;
    public int SlotCnt
    {
        get => slotCnt;
        set
        {
            slotCnt = value;
            onSlotCountChange.Invoke(slotCnt);
        }
    }
    void Start()
    {
        SlotCnt = 4;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
