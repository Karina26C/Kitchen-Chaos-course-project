using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class ContainerCounter : BaseCounter
{
    public event EventHandler onPlayerGrabbedObject;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    
    public override void Interact(Player player)
    {
        Debug.Log("interact!");
        if (!player.HasKitchenObject())
        {
            //player is not carrying anything
            KitchenObject.SpawnKitchenObject(kitchenObjectSO, player);
            onPlayerGrabbedObject?.Invoke(this, EventArgs.Empty);
        }
        
    }  
}
