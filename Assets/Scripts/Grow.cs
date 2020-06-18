using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float growthInterval;

    [SerializeField] private Transform[] childs;

    void Start()
    {
        

        childs = transform.GetComponentsInChildren<Transform>();

        for (int i = 0; i < childs.Length; i++)
        {
            childs[i].gameObject.SetActive(false);
        }
        childs[0].gameObject.SetActive(true);
        StartCoroutine(grow());
    }


    IEnumerator grow()
    {
        yield return new WaitForSeconds(growthInterval);
        for (int i = 2; i < childs.Length; i++)
        {
            childs[i - 1].gameObject.SetActive(false);
            childs[i].gameObject.SetActive(true);

            yield return new WaitForSeconds(growthInterval);
        }
       

    }
}