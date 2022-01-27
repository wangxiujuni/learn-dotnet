using static System.Guid;

namespace ConsoleDI.Example;

public class DefaultOperation : ITransientOperation, IScopedOperation, ISingletonOperation
{
    // 获取 GUID 后 4 位
    public string OperationId { get; } = NewGuid().ToString()[^4..];
}