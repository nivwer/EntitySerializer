namespace nivwer.EntitySerializer.MapperStrategy.Interface;

public interface IMapperStrategy
{
    object? MapValue(Type type, object? value);
}