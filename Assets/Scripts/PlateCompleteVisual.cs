using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlateCompleteVisual : MonoBehaviour
{
    [Serializable]
    public struct KitchennObjectSO_GameObject
    {
        public KitchenObjectSO kitchenObjectSO;
        public GameObject gameObject;
    }

    [SerializeField] private PlateKitchenObject plateKitchenObject;
    [SerializeField] private List<KitchennObjectSO_GameObject> kitchennObjectSOGameObjectList;


    private void Start()
    {
        plateKitchenObject.OnIngredientAdded += PlateKitchenObject_OnIngredientAdded;

        foreach (KitchennObjectSO_GameObject kitchennObjectSOGameObject in kitchennObjectSOGameObjectList)
        {
                kitchennObjectSOGameObject.gameObject.SetActive(false);
        }
    }

    private void PlateKitchenObject_OnIngredientAdded(object sender, PlateKitchenObject.OnIngredientAddedEventArgs e)
    {
        foreach(KitchennObjectSO_GameObject kitchennObjectSOGameObject in kitchennObjectSOGameObjectList)
        {
            if (kitchennObjectSOGameObject.kitchenObjectSO == e.kitchenObjectSO)
            {
                kitchennObjectSOGameObject.gameObject.SetActive(true);
            }
        }
    }
}
