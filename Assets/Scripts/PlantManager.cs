
using UnityEngine;

public class PlantManager : MonoBehaviour
{
    public static PlantManager instance;


     void Awake()
    {
        if(instance != null)
        {
            Debug.LogError("more than one PlantManager in scene!");
            return;
        }
        instance = this;
        
    }

    public GameObject standardPlantPrefab;

     void Start()
    {
        PlantToPlanting = standardPlantPrefab;
    }

    private GameObject PlantToPlanting;


    public GameObject GetPlantToPlant()
    {
        return PlantToPlanting;
    }
}
