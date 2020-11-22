namespace WebAPI.Mapping
{
    public interface IViewModelComId<T> : IMapeavel<T> where T : class
    {
        int Id { get; set; }
    }
}