namespace solid_principles
{
    // Bad Example
    public interface IWorker
    {
        void Work();
        void Eat();
    }

    public class Worker_bad : IWorker
    {
        public void Eat()
        {
            // Eating
        }

        public void Work()
        {
            // Working
        }
    }
    public class Robot_bad : IWorker
    {
        public void Work()
        {
            // Working
        }
        public void Eat()
        {
            // Robots don't eat, but they must implement this method
        }
    }

    // Good Example
    public interface IWorkable
    {
        void Work();
    }
    public interface IEatable
    {
        void Eat();
    }

    public class Worker_good : IWorkable, IEatable
    {
        public void Eat()
        {
            // Eating
        }

        public void Work()
        {
            // Working
        }
    }

    public class Robot_good : IWorkable
    {
        public void Work()
        {
            // Working
        }
    }
}
