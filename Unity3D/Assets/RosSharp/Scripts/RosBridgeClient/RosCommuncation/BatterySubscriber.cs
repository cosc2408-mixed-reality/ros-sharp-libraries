using UnityEngine;

namespace RosSharp.RosBridgeClient
{
    public class BatterySubscriber : Subscriber<Messages.Mobility_Base_Core.BatteryState>
    {
        private float previousRealTime;
        private bool isMessageReceived;

        private float voltage;
        private sbyte state;
        private float charge;

        protected override void Start()
        {
            base.Start();
        }

        protected override void ReceiveMessage(Messages.Mobility_Base_Core.BatteryState message)
        {
            voltage = message.voltage;
            state = message.state;
            charge = message.charge;

            //isMessageReceived = true;
        }

        private void Update()
        {
            Debug.Log(charge);


            //if (isMessageReceived)
              //  ProcessMessage();
        }
        /*private void ProcessMessage()
        {
            Debug.Log(voltage.ToString());

            isMessageReceived = false;
        }*/
    }
}