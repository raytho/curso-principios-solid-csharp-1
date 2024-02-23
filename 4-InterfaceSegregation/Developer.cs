namespace InterfaceSegregation
{
    public class Developer : IWorkActivities, IDeveloperActivities
    {
        public Developer()
        {
        }

        public void Comunicate()
        {
            throw new NotImplementedException();
        }

        public void Develop()
        {
            throw new NotImplementedException();
        }

        public void Plan()
        {
            throw new NotImplementedException();
        }
    }
}