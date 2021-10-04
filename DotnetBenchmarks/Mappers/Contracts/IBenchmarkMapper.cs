namespace Mappers.Contracts
{
    interface IBenchmarkMapper<TFrom, TTo>
    {
        TTo Map(TFrom entity);
    }
}
