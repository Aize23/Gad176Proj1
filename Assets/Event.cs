using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Aize23
{
    public class Event : MonoBehaviour
    {

        protected int stressModifier = 0;

        [SerializeField]
        private string eventName = "placeholder";
        [SerializeField]
        private string eventFlavText = "placeholder";
        [SerializeField]
        private object eventParticles = null;

        // Start is called before the first frame update
        void Start()
        {
            //runs event
            RunEvt();
        }

        //runs the start of the event, when nothing left, runs the end of the event
        protected void RunEvt()
        {

            //Triggers any extra stuff
            OnRunEvt();


            void EndEvt()
            {
                //end this evt
                OnEndEvt();
            }
        }
        void OnRunEvt()
        {

        }
        void OnEndEvt()
        {

        }
    }

    class Encounter : Event
    {

    }

}