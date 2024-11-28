using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace InteractiveToy
{
    public class lightControl : MonoBehaviour
    {
        //public SunMechanics sun;
        public Light lampLight;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {

            //Debug.Log(SunMechanics.x);
            if (SunMechanics.x >= 180f) lampLight.intensity = 20;
            else lampLight.intensity = 0;
        }
    }
}
