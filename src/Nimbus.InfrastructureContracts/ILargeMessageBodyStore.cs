using System;
using System.Threading.Tasks;

namespace Nimbus
{
    public interface ILargeMessageBodyStore
    {
        Task<string> Store(string id, byte[] bytes, DateTimeOffset expiresAfter);
        Task<byte[]> Retrieve(string storageKey);
        Task Delete(string storageKey);
    }
}