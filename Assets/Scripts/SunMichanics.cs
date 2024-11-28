using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InteractiveToy
{
    public class SunMechanics : MonoBehaviour
    {
        public static float x;
        public static int daysCount = 0;

        public LiftMechanics liftMechanics;


        void Start()
        {
            x = transform.eulerAngles.x;
        }

        void Update()
        {
            //Debug.Log(liftMechanics.isOn);
            if (liftMechanics.isOn)
            {
                if (x >= 360)
                {
                    x = 0;
                    daysCount++;
                    //Debug.Log(daysCount);
                }

                transform.rotation = Quaternion.Euler(new Vector3(++x, -30f, 0));
            }
        }

    }

}