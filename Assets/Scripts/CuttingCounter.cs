using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuttingCounter : BaseCounter
{
    // test comment

    [SerializeField] private KitchenObjectSO cutKitchenObjectSO;
    public override void Interact(Player player)
    {
        if (!HasKitchenObject())
        {
            // There is no KitchenObject here
            if (player.HasKitchenObject())
            {
                player.GetKitchenObject().SetKitchenObjectParent(this);
            }
            else
            {
                //player is not carrying anything
            }
        }
        else
        {
            // There is a KitcheOnbject here
            if (player.HasKitchenObject())
            {
                // Player is carrying smth
            }
            else
            {
                // Player is not carrying anything
                GetKitchenObject().SetKitchenObjectParent(player);
            }

        }
    }

    public override void InteractAlternate(Player player)
    {
        if (HasKitchenObject())
        {
            GetKitchenObject().DestroySelf();
            KitchenObject.SpawnKitchenObject(cutKitchenObjectSO, this);
        }
    }
}

