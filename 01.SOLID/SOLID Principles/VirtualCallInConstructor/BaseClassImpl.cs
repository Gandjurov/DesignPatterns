namespace VirtualCallInConstructor
{
    public class BaseClassImpl : BaseClass
    {
        private readonly DatabaseRepository databaseRepository;

        public BaseClassImpl()
        {
            this.databaseRepository = new DatabaseRepository();
        }

        protected override void AddToDatabase()
        {
            this.databaseRepository.Add();
        }
    }
}
