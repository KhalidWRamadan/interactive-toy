using System.Collections;
using System.Collections.Generic;
using InteractiveToy;
using UnityEngine;

public class TreeControl : MonoBehaviour
{
    public GameObject smallTrees;
    public GameObject mediumTrees;
    public GameObject bigTrees;
    // Start is called before the first frame update
    void Start()
    {
        smallTrees.SetActive(true);
        mediumTrees.SetActive(false);
        bigTrees.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        if (SunMechanics.daysCount > 3 && SunMechanics.daysCount <= 5)
        {
            smallTrees.SetActive(false);
            mediumTrees.SetActive(true);
            bigTrees.SetActive(false);

        }
        else if (SunMechanics.daysCount >= 5)
        {
            smallTrees.SetActive(false);
            mediumTrees.SetActive(false);
            bigTrees.SetActive(true);

        }
    }
}
