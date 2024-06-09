namespace BackEnd.Models.Mappers
{
    public interface IMap<TDto, TEntity>
    {
        TEntity map(TDto dto);
        TEntity map(TDto dto, TEntity entity);
    }
}
