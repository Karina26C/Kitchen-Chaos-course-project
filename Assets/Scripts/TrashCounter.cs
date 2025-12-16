using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrashCounter : BaseCounter
{
    private KitchenObjectSO KitchenObjectSO;
    public override void Interact(Player player)
    {
        if (player.HasKitchenObject())
        {
            //Added a comment
            player.GetKitchenObject().DestroySelf();
        }
    }
}
