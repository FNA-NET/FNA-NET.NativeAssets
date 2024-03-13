using System;
using System.Runtime.InteropServices;

namespace MoltenVK
{
#if __IOS__ || __TVOS__
    [Foundation.Preserve(AllMembers=true)]
#endif
    public static class VK
    {
#if __IOS__ || __TVOS__
        const string nativeLibName = "__Internal";
#else
        const string nativeLibName = "MoltenVK";
#endif

        [DllImport(nativeLibName, CallingConvention = CallingConvention.StdCall)]
        public static extern void vkGetVersionStringsMVK(
            IntPtr pMoltenVersionStringBuffer,
            uint  moltenVersionStringBufferLength,
            IntPtr pVulkanVersionStringBuffer,
            uint  vulkanVersionStringBufferLength);
    }
}