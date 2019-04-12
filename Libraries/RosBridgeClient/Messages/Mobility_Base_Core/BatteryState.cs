using Newtonsoft.Json;

namespace RosSharp.RosBridgeClient.Messages.Mobility_Base_Core
{

    public class BatteryState : Message
    {
        [JsonIgnore]
        public const string RosMessageName = "mobility_base_core_msgs/BatteryState";
        public Standard.Header header;

        public float voltage;
        public float rate;
        public float charge;
        public float capacity;

        public sbyte percent;
        public sbyte state;

        public BatteryState()
        {
            header = new Standard.Header();
            voltage = new float();
            rate = new float();
            charge = new float();
            capacity = new float();

            percent = new sbyte();
            state = new sbyte();
        }
    }
}

