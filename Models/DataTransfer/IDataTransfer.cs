namespace DingjiaHpmc.Models.DataTransfer
{
    public interface IDataTransfer<EType, IdType>
    {
        EType Build(IdType id);
        void Extract(EType entity);
    }
}
