using System;
using System.Linq;

namespace HexToBase64 {
    public static class Converter {
        private const string HexStr = "4a1b48d7322394a78326cd283f0834093e65421a7e98e90e5b452d160b5d07d8";

        public static string CovertToBase64() {
            // LINQ to get the bytes of the hex string
            var bytes = Enumerable.Range(0, HexStr.Length)
                .Where(x => x % 2 == 0)
                .Select(x => Convert.ToByte(HexStr.Substring(x, 2), 16));
            
            
            // return the bytes converted to Base64
            return Convert.ToBase64String(bytes.ToArray());
        }
    }
}