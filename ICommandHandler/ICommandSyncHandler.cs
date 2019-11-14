namespace ICommandHandler
{
    public interface ICommandSyncHandler<T>
    {
        void Handle(T command);
    }
}
