using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MysteryCounter : BaseCounter, IKitchenObjectParent
{
    [SerializeField] private MysteryCounter mysteryCounter;
    [SerializeField] private KitchenObjectSO kitchenObjectSO;
    [SerializeField] private KitchenObjectSO tomato;
    public List<KitchenObjectSO> KitchenObjectSOList;
    public override void Interact(Player player)
    {
        base.Interact(player);

        if (!player.HasKitchenObject())
        {
            //player is not carrying anything
            KitchenObject.SpawnKitchenObject(KitchenObjectSOList[Random.Range(0, KitchenObjectSOList.Count)], player);
        } 
        
        else
        {
            Debug.Log("es inch eshutyuna");
            if(player.GetKitchenObject().GetKitchenObjectSO() == tomato)
            {
                Debug.Log("qneeel");
                Destroy(player.GetKitchenObject().gameObject); 
            }
        }
    }
}
