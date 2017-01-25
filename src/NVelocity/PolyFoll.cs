#if NETSTANDARD
namespace System
{
    public class SystemException : Exception { }
}

namespace System.IO
{
    public static class MemoryStreamExtensions
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
