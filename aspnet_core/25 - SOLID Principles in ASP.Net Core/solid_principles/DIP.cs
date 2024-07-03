namespace solid_principles
{
    // Bad Example
    public class LightBulb_bad
    {
        public void TurnOn()
        {
            // Turn on the light bulb
        }
        public void TurnOff()
        {
            // Turn off the light bulb
        }
    }

    public class Switch_bad
    {
        private readonly LightBulb_bad _lightBulb = new LightBulb_bad();
        public void Operate()
        {
            _lightBulb.TurnOn();
        }
    }

    // Good Example
    public interface ILight
    {
        void TurnOn();
        void TurnOff();
    }
    public class LightBulb : ILight
    {
        public void TurnOff()
        {
            // Turn off the light bulb
        }

        public void TurnOn()
        {
            // Turn on the light bulb
        }
    }

    public class Switch
    {
        private readonly ILight _light;
        public Switch(ILight ilight)
        {
            _light = ilight;
        }
        public void Operate()
        {
            _light.TurnOn();
        }
    }
}
