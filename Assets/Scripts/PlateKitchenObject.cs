using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlateKitchenObject : KitchenObject
{
    [SerializeField] private List<KitchenObjectSO> validKitcheObjectSOList;

    private List<KitchenObjectSO> kitchenObjectSOList;

    public void Awake()
    {
        kitchenObjectSOList = new List<KitchenObjectSO>();
    }


    public bool TryAddIngredient(KitchenObjectSO kitchenObjectSO)
    {
        if (!validKitcheObjectSOList.Contains(kitchenObjectSO))
        {
            return false;
        }
        if (kitchenObjectSOList.Contains(kitchenObjectSO))
        {
            return false;
        }
        else
        {
            kitchenObjectSOList.Add(kitchenObjectSO);
            return true;
        }
    }
}
