namespace VirtualCallInConstructor
{
    public abstract class BaseClass
    {
        protected BaseClass()
        {
            this.AddToDatabase();
        }

        protected virtual void AddToDatabase()
        {
        }
    }
}
