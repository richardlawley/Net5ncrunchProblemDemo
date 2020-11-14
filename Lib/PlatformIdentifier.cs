using System;

namespace Lib
{
    public static class PlatformIdentifier
    {
		public static string GetPlatform() {
			#if NETSTANDARD
				return "NET Standard";
			#else
				return "Something else";
			#endif
		}
    }
}
