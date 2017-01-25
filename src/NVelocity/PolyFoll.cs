#if NETSTANDARD
namespace System
{
    internal class SerializableAttribute : Attribute { }
    internal class SystemException : Exception { }
}

namespace System.IO
{
    internal static class MemoryStreamExtensions
    {
        public static byte[] GetBuffer(this MemoryStream stream)
        {
            ArraySegment<byte> result;
            if (stream.TryGetBuffer(out result))
            {
                return result.Array;
            }
            throw new Exception("Not exposable");
        }
    }
}
#endif
