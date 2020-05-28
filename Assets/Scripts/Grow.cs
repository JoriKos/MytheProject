using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grow : MonoBehaviour
{
    [SerializeField] private float growthInterval;

    Transform[] childs;

    void Start()
    {
        /*
        transform.GetChild(0).gameObject.SetActive(true);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(false);
        */

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
        for (int i = 1; i < childs.Length; i++)
        {
            transform.GetChild(i - 1).gameObject.SetActive(false);
            transform.GetChild(i).gameObject.SetActive(true);

            yield return new WaitForSeconds(growthInterval);
        }
        /*
        yield return new WaitForSeconds(5);
        transform.GetChild(0).gameObject.SetActive(false);
        transform.GetChild(1).gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        transform.GetChild(1).gameObject.SetActive(false);
        transform.GetChild(2).gameObject.SetActive(true);
        yield return new WaitForSeconds(5);
        transform.GetChild(2).gameObject.SetActive(false);
        transform.GetChild(3).gameObject.SetActive(true);
        StopCoroutine(grow());
        */

    }
}