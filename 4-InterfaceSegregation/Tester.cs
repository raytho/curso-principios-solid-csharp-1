namespace InterfaceSegregation
{
    public class Tester : IWorkActivities ,ITesterActivities
    {
        public Tester()
        {
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }

        public void Test()
        {
            throw new NotImplementedException();
        }
    }
}