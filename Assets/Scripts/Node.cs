
using UnityEngine;

public class Node : MonoBehaviour
{

    public Color hoverColor;
    public Vector3 positionOffset;

    private GameObject plant;

    private Renderer rend;
    private Color startColor;

     void Start()
    {
        rend = GetComponent<Renderer>();
        startColor = rend.material.color;
    }

     void OnMouseDown()
    {
       if(plant != null)
        {
            Debug.Log("Can't plant there!");
        }

        GameObject PlantToPlanting = PlantManager.instance.GetPlantToPlant();
        plant = (GameObject)Instantiate(PlantToPlanting, transform.position + positionOffset, transform.rotation);
    }

    void OnMouseEnter()
    {
       rend.material.color = hoverColor;
    }

     void OnMouseExit()
    {
        rend.material.color = startColor;
    }
}
