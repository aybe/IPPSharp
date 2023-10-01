using System.Runtime.InteropServices;

using System;
using System.Diagnostics;

namespace Intel
{
    /// <summary>Defines the type of a member as it was used in the native signature.</summary>
    [AttributeUsage(AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue, AllowMultiple = false, Inherited = true)]
    [Conditional("DEBUG")]
    internal sealed partial class NativeTypeNameAttribute : Attribute
    {
        private readonly string _name;

        /// <summary>Initializes a new instance of the <see cref="NativeTypeNameAttribute" /> class.</summary>
        /// <param name="name">The name of the type that was used in the native signature.</param>
        public NativeTypeNameAttribute(string name)
        {
            _name = name;
        }

        /// <summary>Gets the name of the type that was used in the native signature.</summary>
        public string Name => _name;
    }
}
namespace Intel
{
    public static unsafe partial class ipps
    {
        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("const IppLibraryVersion *")]
        public static extern IppLibraryVersion* ippsGetLibVersion();

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp8u *")]
        public static extern byte* ippsMalloc_8u(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp16u *")]
        public static extern ushort* ippsMalloc_16u(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp32u *")]
        public static extern uint* ippsMalloc_32u(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp8s *")]
        public static extern sbyte* ippsMalloc_8s(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp16s *")]
        public static extern short* ippsMalloc_16s(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp32s *")]
        public static extern int* ippsMalloc_32s(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp64s *")]
        public static extern long* ippsMalloc_64s(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp32f *")]
        public static extern float* ippsMalloc_32f(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("Ipp64f *")]
        public static extern double* ippsMalloc_64f(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp8sc* ippsMalloc_8sc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp16sc* ippsMalloc_16sc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp32sc* ippsMalloc_32sc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp64sc* ippsMalloc_64sc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp32fc* ippsMalloc_32fc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern Ipp64fc* ippsMalloc_64fc(int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        public static extern void ippsFree(void* ptr);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_32sc([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_64s([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp64s *")] long* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopy_64sc([NativeTypeName("const Ipp64sc *")] Ipp64sc* pSrc, Ipp64sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopyLE_1u([NativeTypeName("const Ipp8u *")] byte* pSrc, int srcBitOffset, [NativeTypeName("Ipp8u *")] byte* pDst, int dstBitOffset, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCopyBE_1u([NativeTypeName("const Ipp8u *")] byte* pSrc, int srcBitOffset, [NativeTypeName("Ipp8u *")] byte* pDst, int dstBitOffset, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_32sc([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_64s([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp64s *")] long* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMove_64sc([NativeTypeName("const Ipp64sc *")] Ipp64sc* pSrc, Ipp64sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_8u([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_16s([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_16sc(Ipp16sc val, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_32s([NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_32sc(Ipp32sc val, Ipp32sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_32f([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_32fc(Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_64s([NativeTypeName("Ipp64s")] long val, [NativeTypeName("Ipp64s *")] long* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_64sc(Ipp64sc val, Ipp64sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_64f([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSet_64fc(Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_8u([NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_16s([NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_16sc(Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_32f([NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_32fc(Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_64f([NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_64fc(Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_32s([NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_32sc(Ipp32sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_64s([NativeTypeName("Ipp64s *")] long* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZero_64sc(Ipp64sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f *")] float* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_16sc(Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f *")] float* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f *")] float* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_32fc(Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f *")] float* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double magn, [NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f *")] double* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTone_64fc(Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double magn, [NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f *")] double* pPhase, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double magn, [NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f")] double asym, [NativeTypeName("Ipp64f *")] double* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_64fc(Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double magn, [NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f")] double asym, [NativeTypeName("Ipp64f *")] double* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f")] float asym, [NativeTypeName("Ipp32f *")] float* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_32fc(Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f")] float asym, [NativeTypeName("Ipp32f *")] float* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f")] float asym, [NativeTypeName("Ipp32f *")] float* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTriangle_16sc(Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short magn, [NativeTypeName("Ipp32f")] float rFreq, [NativeTypeName("Ipp32f")] float asym, [NativeTypeName("Ipp32f *")] float* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniform_8u([NativeTypeName("Ipp8u *")] byte* pDst, int len, [NativeTypeName("IppsRandUniState_8u *")] RandUniState_8u* pRandUniState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniform_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("IppsRandUniState_16s *")] RandUniState_16s* pRandUniState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniform_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsRandUniState_32f *")] RandUniState_32f* pRandUniState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniform_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("IppsRandUniState_64f *")] RandUniState_64f* pRandUniState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGauss_8u([NativeTypeName("Ipp8u *")] byte* pDst, int len, [NativeTypeName("IppsRandGaussState_8u *")] RandGaussState_8u* pRandGaussState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGauss_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("IppsRandGaussState_16s *")] RandGaussState_16s* pRandGaussState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGauss_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsRandGaussState_32f *")] RandGaussState_32f* pRandGaussState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGauss_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("IppsRandGaussState_64f *")] RandGaussState_64f* pRandGaussState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussGetSize_8u(int* pRandGaussStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussGetSize_16s(int* pRandGaussStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussGetSize_32f(int* pRandGaussStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussGetSize_64f(int* pRandGaussStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussInit_8u([NativeTypeName("IppsRandGaussState_8u *")] RandGaussState_8u* pRandGaussState, [NativeTypeName("Ipp8u")] byte mean, [NativeTypeName("Ipp8u")] byte stdDev, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussInit_16s([NativeTypeName("IppsRandGaussState_16s *")] RandGaussState_16s* pRandGaussState, [NativeTypeName("Ipp16s")] short mean, [NativeTypeName("Ipp16s")] short stdDev, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussInit_32f([NativeTypeName("IppsRandGaussState_32f *")] RandGaussState_32f* pRandGaussState, [NativeTypeName("Ipp32f")] float mean, [NativeTypeName("Ipp32f")] float stdDev, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandGaussInit_64f([NativeTypeName("IppsRandGaussState_64f *")] RandGaussState_64f* pRandGaussState, [NativeTypeName("Ipp64f")] double mean, [NativeTypeName("Ipp64f")] double stdDev, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformGetSize_8u(int* pRandUniformStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformGetSize_16s(int* pRandUniformStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformGetSize_32f(int* pRandUniformStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformGetSize_64f(int* pRandUniformStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformInit_8u([NativeTypeName("IppsRandUniState_8u *")] RandUniState_8u* pRandUniState, [NativeTypeName("Ipp8u")] byte low, [NativeTypeName("Ipp8u")] byte high, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformInit_16s([NativeTypeName("IppsRandUniState_16s *")] RandUniState_16s* pRandUniState, [NativeTypeName("Ipp16s")] short low, [NativeTypeName("Ipp16s")] short high, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformInit_32f([NativeTypeName("IppsRandUniState_32f *")] RandUniState_32f* pRandUniState, [NativeTypeName("Ipp32f")] float low, [NativeTypeName("Ipp32f")] float high, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRandUniformInit_64f([NativeTypeName("IppsRandUniState_64f *")] RandUniState_64f* pRandUniState, [NativeTypeName("Ipp64f")] double low, [NativeTypeName("Ipp64f")] double high, [NativeTypeName("unsigned int")] uint seed);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_8u([NativeTypeName("Ipp8u *")] byte* pDst, int len, [NativeTypeName("Ipp8u")] byte magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_16u([NativeTypeName("Ipp16u *")] ushort* pDst, int len, [NativeTypeName("Ipp16u")] ushort magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_32s([NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorJaehne_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double magn);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_8u([NativeTypeName("Ipp8u *")] byte* pDst, int len, [NativeTypeName("Ipp32f")] float offset, [NativeTypeName("Ipp32f")] float slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_16u([NativeTypeName("Ipp16u *")] ushort* pDst, int len, [NativeTypeName("Ipp32f")] float offset, [NativeTypeName("Ipp32f")] float slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_16s([NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp32f")] float offset, [NativeTypeName("Ipp32f")] float slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_32u([NativeTypeName("Ipp32u *")] uint* pDst, int len, [NativeTypeName("Ipp64f")] double offset, [NativeTypeName("Ipp64f")] double slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_32s([NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp64f")] double offset, [NativeTypeName("Ipp64f")] double slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_32f([NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float offset, [NativeTypeName("Ipp32f")] float slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsVectorSlope_64f([NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double offset, [NativeTypeName("Ipp64f")] double slope);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_8u_I([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_16u_I([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_32u_I([NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAndC_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_8u_I([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_8u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_16u_I([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_32u_I([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAnd_32u([NativeTypeName("const Ipp32u *")] uint* pSrc1, [NativeTypeName("const Ipp32u *")] uint* pSrc2, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_8u_I([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_16u_I([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_32u_I([NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOrC_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_8u_I([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_8u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_16u_I([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_32u_I([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsOr_32u([NativeTypeName("const Ipp32u *")] uint* pSrc1, [NativeTypeName("const Ipp32u *")] uint* pSrc2, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_8u_I([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_16u_I([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_32u_I([NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXorC_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u")] uint val, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_8u_I([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_8u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_16u_I([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_32u_I([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsXor_32u([NativeTypeName("const Ipp32u *")] uint* pSrc1, [NativeTypeName("const Ipp32u *")] uint* pSrc2, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_32u_I([NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNot_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_8u_I(int val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, int val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_16u_I(int val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, int val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_16s_I(int val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int val, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_32s_I(int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLShiftC_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int val, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_8u_I(int val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, int val, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_16u_I(int val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, int val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_16s_I(int val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int val, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_32s_I(int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRShiftC_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int val, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_8u_ISfs([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16s_I([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16s_ISfs([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16u_ISfs([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32s_ISfs([NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64u_Sfs([NativeTypeName("const Ipp64u *")] ulong* pSrc, [NativeTypeName("Ipp64u")] ulong val, [NativeTypeName("Ipp64u *")] ulong* pDst, [NativeTypeName("Ipp32u")] uint len, int scaleFactor, IppRoundMode rndMode);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64s_Sfs([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp64s")] long val, [NativeTypeName("Ipp64s *")] long* pDst, [NativeTypeName("Ipp32u")] uint len, int scaleFactor, IppRoundMode rndMode);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64f_I([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_8u_ISfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_8u16u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s_ISfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s32s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16sc_ISfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16u_ISfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32s_ISfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32sc_ISfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc1, [NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32u([NativeTypeName("const Ipp32u *")] uint* pSrc1, [NativeTypeName("const Ipp32u *")] uint* pSrc2, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32u_I([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_64s_Sfs([NativeTypeName("const Ipp64s *")] long* pSrc1, [NativeTypeName("const Ipp64s *")] long* pSrc2, [NativeTypeName("Ipp64s *")] long* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32fc_I([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_64fc_I([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAdd_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProductC_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("const Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProductC_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("const Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAddProduct_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_8u_ISfs([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16s_I([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16s_ISfs([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16u_ISfs([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32s_ISfs([NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64s_ISfs([NativeTypeName("Ipp64s")] long val, [NativeTypeName("Ipp64s *")] long* pSrcDst, [NativeTypeName("Ipp32u")] uint len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_32f16s_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_Low_32f16s([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64f_I([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulC_64f64s_ISfs([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64s *")] long* pSrcDst, [NativeTypeName("Ipp32u")] uint len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_8u_ISfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_8u16u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s_ISfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16sc_ISfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16u_ISfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_16u16s_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32s_ISfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32sc_ISfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc1, [NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32fc_I([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32f32fc_I([NativeTypeName("const Ipp32f *")] float* pSrc, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_32f32fc([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_64fc_I([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMul_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_8u_ISfs([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16s_I([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16s_ISfs([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16u_ISfs([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32s_ISfs([NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_64f_I([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_8u_ISfs([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16s_ISfs([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16u_ISfs([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32s_ISfs([NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int val, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32sc_ISfs(Ipp32sc val, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc val, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_64f_I([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSubCRev_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_8u_ISfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16s([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16s_ISfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16sc_ISfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16u_ISfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32s_ISfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32sc_ISfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc1, [NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc2, Ipp32sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32fc_I([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_64fc_I([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSub_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_8u_ISfs([NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u")] byte val, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16s_ISfs([NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s")] short val, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16sc_ISfs(Ipp16sc val, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc val, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16u_ISfs([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_64s_ISfs([NativeTypeName("Ipp64s")] long val, [NativeTypeName("Ipp64s *")] long* pSrcDst, [NativeTypeName("Ipp32u")] uint len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_32fc_I(Ipp32fc val, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc val, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_64f_I([NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f")] double val, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_64fc_I(Ipp64fc val, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc val, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivCRev_16u_I([NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivCRev_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u")] ushort val, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivCRev_32f_I([NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDivCRev_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f")] float val, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_8u_ISfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16s_ISfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16sc_ISfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32s_ISfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32s16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16u_ISfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32fc_I([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_64fc_I([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_8u_ISfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_16s_ISfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, [NativeTypeName("Ipp16s *")] short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_16u_ISfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDiv_Round_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAbs_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_8u_ISfs([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16sc_ISfs(Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16u_ISfs([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqr_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_8u_ISfs([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_8u_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16sc_ISfs(Ipp16sc* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16u_ISfs([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_16u_Sfs([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_32s16s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSqrt_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCubrt_32s16s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int Len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCubrt_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_32s_ISfs([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsExp_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_32s_ISfs([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsLn_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumLn_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumLn_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumLn_32f64f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumLn_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsArctan_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsArctan_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsArctan_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsArctan_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short vSub, int vDiv, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short vSub, int vDiv, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_16sc_ISfs(Ipp16sc* pSrcDst, int len, Ipp16sc vSub, int vDiv, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, Ipp16sc vSub, int vDiv, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float vSub, [NativeTypeName("Ipp32f")] float vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float vSub, [NativeTypeName("Ipp32f")] float vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_32fc_I(Ipp32fc* pSrcDst, int len, Ipp32fc vSub, [NativeTypeName("Ipp32f")] float vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, Ipp32fc vSub, [NativeTypeName("Ipp32f")] float vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double vSub, [NativeTypeName("Ipp64f")] double vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double vSub, [NativeTypeName("Ipp64f")] double vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_64fc_I(Ipp64fc* pSrcDst, int len, Ipp64fc vSub, [NativeTypeName("Ipp64f")] double vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormalize_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, Ipp64fc vSub, [NativeTypeName("Ipp64f")] double vDiv);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortAscend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortDescend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexAscend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortIndexDescend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int* pDstIdx, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixGetBufferSize(int len, IppDataType dataType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexGetBufferSize(int len, IppDataType dataType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_32u_I([NativeTypeName("Ipp32u *")] uint* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_64u_I([NativeTypeName("Ipp64u *")] ulong* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_64s_I([NativeTypeName("Ipp64s *")] long* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixAscend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_32u_I([NativeTypeName("Ipp32u *")] uint* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_64u_I([NativeTypeName("Ipp64u *")] ulong* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_64s_I([NativeTypeName("Ipp64s *")] long* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixDescend_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_64s([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_64u([NativeTypeName("const Ipp64u *")] ulong* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexAscend_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_64s([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_64u([NativeTypeName("const Ipp64u *")] ulong* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSortRadixIndexDescend_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp32s")] int srcStrideBytes, [NativeTypeName("Ipp32s *")] int* pDstIndx, int len, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_24u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_24u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_32u_I([NativeTypeName("Ipp32u *")] uint* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_64u_I([NativeTypeName("Ipp64u *")] ulong* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSwapBytes_64u([NativeTypeName("const Ipp64u *")] ulong* pSrc, [NativeTypeName("Ipp64u *")] ulong* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_8s16s([NativeTypeName("const Ipp8s *")] sbyte* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_8s32f([NativeTypeName("const Ipp8s *")] sbyte* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_8u32f([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s8s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp8s *")] sbyte* pDst, [NativeTypeName("Ipp32u")] uint len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s32s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s16f([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16f *")] short* pDst, int len, IppRoundMode rndMode);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s32f_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16s64f_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16u32f([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_24s32s([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_24s32f([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_24u32u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32u *")] uint* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_24u32f([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s16s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s16s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s24s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s32f([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s32f_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s64f([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32s64f_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32u24u_Sfs([NativeTypeName("const Ipp32u *")] uint* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64s32s_Sfs([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64s64f([NativeTypeName("const Ipp64s *")] long* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16f16s_Sfs([NativeTypeName("const Ipp16f *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_16f32f([NativeTypeName("const Ipp16f *")] short* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f8s_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp8s *")] sbyte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f8u_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f16s_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f16u_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f24s_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f24u_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f32s_Sfs([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f16f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp16f *")] short* pDst, int len, IppRoundMode rndMode);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_32f64f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f16s_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f32s_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f64s_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64s *")] long* pDst, [NativeTypeName("Ipp32u")] uint len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f32f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_8s8u([NativeTypeName("const Ipp8s *")] sbyte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_8u8s_Sfs([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8s *")] sbyte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f8s_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp8s *")] sbyte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f8u_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvert_64f16u_Sfs([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len, IppRoundMode rndMode, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConj_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjFlip_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjFlip_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjFlip_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjCcs_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjCcs_32fc([NativeTypeName("const Ipp32f *")] float* pSrc, Ipp32fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjCcs_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjCcs_64fc([NativeTypeName("const Ipp64f *")] double* pSrc, Ipp64fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPack_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPack_32fc([NativeTypeName("const Ipp32f *")] float* pSrc, Ipp32fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPack_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPack_64fc([NativeTypeName("const Ipp64f *")] double* pSrc, Ipp64fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPerm_32fc_I(Ipp32fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPerm_32fc([NativeTypeName("const Ipp32f *")] float* pSrc, Ipp32fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPerm_64fc_I(Ipp64fc* pSrcDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConjPerm_64fc([NativeTypeName("const Ipp64f *")] double* pSrc, Ipp64fc* pDst, int lenDst);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_16s32f([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_16sc32f([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMagnitude_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_16sc32f([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_16s32f([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPhase_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_16s32f([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_16sc32f([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPowerSpectr_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsReal_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDstRe, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsReal_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDstRe, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsReal_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDstRe, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsImag_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsImag_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsImag_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRealToCplx_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRealToCplx_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsRealToCplx_16s([NativeTypeName("const Ipp16s *")] short* pSrcRe, [NativeTypeName("const Ipp16s *")] short* pSrcIm, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCplxToReal_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCplxToReal_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCplxToReal_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDstRe, [NativeTypeName("Ipp16s *")] short* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level, IppCmpOp relOp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LT_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GT_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbs_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTAbs_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int level, [NativeTypeName("Ipp32s")] int value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int level, [NativeTypeName("Ipp32s")] int value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTAbsVal_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, Ipp16sc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, Ipp32fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, Ipp64fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short level, Ipp16sc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level, Ipp32fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTVal_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level, Ipp64fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp16s")] short level, Ipp16sc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level, Ipp32fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level, Ipp64fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short level, [NativeTypeName("Ipp16s")] short value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp16s")] short level, Ipp16sc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level, Ipp32fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_GTVal_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level, Ipp64fc value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp16s")] short levelLT, [NativeTypeName("Ipp16s")] short valueLT, [NativeTypeName("Ipp16s")] short levelGT, [NativeTypeName("Ipp16s")] short valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp16s")] short levelLT, [NativeTypeName("Ipp16s")] short valueLT, [NativeTypeName("Ipp16s")] short levelGT, [NativeTypeName("Ipp16s")] short valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("Ipp32s")] int levelLT, [NativeTypeName("Ipp32s")] int valueLT, [NativeTypeName("Ipp32s")] int levelGT, [NativeTypeName("Ipp32s")] int valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("Ipp32s")] int levelLT, [NativeTypeName("Ipp32s")] int valueLT, [NativeTypeName("Ipp32s")] int levelGT, [NativeTypeName("Ipp32s")] int valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float levelLT, [NativeTypeName("Ipp32f")] float valueLT, [NativeTypeName("Ipp32f")] float levelGT, [NativeTypeName("Ipp32f")] float valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float levelLT, [NativeTypeName("Ipp32f")] float valueLT, [NativeTypeName("Ipp32f")] float levelGT, [NativeTypeName("Ipp32f")] float valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double levelLT, [NativeTypeName("Ipp64f")] double valueLT, [NativeTypeName("Ipp64f")] double levelGT, [NativeTypeName("Ipp64f")] double valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTValGTVal_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double levelLT, [NativeTypeName("Ipp64f")] double valueLT, [NativeTypeName("Ipp64f")] double levelGT, [NativeTypeName("Ipp64f")] double valueGT);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsThreshold_LTInv_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double level);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCartToPolar_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, [NativeTypeName("Ipp32f *")] float* pDstMagn, [NativeTypeName("Ipp32f *")] float* pDstPhase, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCartToPolar_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, [NativeTypeName("Ipp64f *")] double* pDstMagn, [NativeTypeName("Ipp64f *")] double* pDstPhase, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCartToPolar_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDstMagn, [NativeTypeName("Ipp32f *")] float* pDstPhase, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCartToPolar_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDstMagn, [NativeTypeName("Ipp64f *")] double* pDstPhase, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCartToPolar_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, [NativeTypeName("Ipp16s *")] short* pDstMagn, [NativeTypeName("Ipp16s *")] short* pDstPhase, int len, int magnScaleFactor, int phaseScaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPolarToCart_32fc([NativeTypeName("const Ipp32f *")] float* pSrcMagn, [NativeTypeName("const Ipp32f *")] float* pSrcPhase, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPolarToCart_64fc([NativeTypeName("const Ipp64f *")] double* pSrcMagn, [NativeTypeName("const Ipp64f *")] double* pSrcPhase, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPolarToCart_32f([NativeTypeName("const Ipp32f *")] float* pSrcMagn, [NativeTypeName("const Ipp32f *")] float* pSrcPhase, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPolarToCart_64f([NativeTypeName("const Ipp64f *")] double* pSrcMagn, [NativeTypeName("const Ipp64f *")] double* pSrcPhase, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPolarToCart_16sc_Sfs([NativeTypeName("const Ipp16s *")] short* pSrcMagn, [NativeTypeName("const Ipp16s *")] short* pSrcPhase, Ipp16sc* pDst, int len, int magnScaleFactor, int phaseScaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_16u_I([NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFlip_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFindNearestOne_16u([NativeTypeName("Ipp16u")] ushort inpVal, [NativeTypeName("Ipp16u *")] ushort* pOutVal, int* pOutIndex, [NativeTypeName("const Ipp16u *")] ushort* pTable, int tblLen);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFindNearest_16u([NativeTypeName("const Ipp16u *")] ushort* pVals, [NativeTypeName("Ipp16u *")] ushort* pOutVals, int* pOutIndexes, int len, [NativeTypeName("const Ipp16u *")] ushort* pTable, int tblLen);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBartlett_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHann_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinHamming_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackman_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanStd_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_16sc_I(Ipp16sc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_32fc_I(Ipp32fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_64fc_I(Ipp64fc* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinBlackmanOpt_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_16sc_I(Ipp16sc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("Ipp32f")] float alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWinKaiser_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("Ipp64f")] double alpha);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pSum, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int len, Ipp16sc* pSum, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pSum, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_16sc32sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int len, Ipp32sc* pSum, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pSum, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pSum, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, Ipp32fc* pSum, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSum_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, Ipp64fc* pSum);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMin_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMin);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMin_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMin);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMin_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMin);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMin_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMin);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMax_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMax_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMax_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMax_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, int len, [NativeTypeName("Ipp8u *")] byte* pMin, [NativeTypeName("Ipp8u *")] byte* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, int len, [NativeTypeName("Ipp16u *")] ushort* pMin, [NativeTypeName("Ipp16u *")] ushort* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMin, [NativeTypeName("Ipp16s *")] short* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, int len, [NativeTypeName("Ipp32u *")] uint* pMin, [NativeTypeName("Ipp32u *")] uint* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMin, [NativeTypeName("Ipp32s *")] int* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMin, [NativeTypeName("Ipp32f *")] float* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMax_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMin, [NativeTypeName("Ipp64f *")] double* pMax);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbs_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMinAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbs_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMinAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbs_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMinAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbs_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMinAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbs_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMaxAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbs_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMaxAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbs_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMaxAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbs_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMaxAbs);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinIndx_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMin, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinIndx_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMin, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinIndx_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMin, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinIndx_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMin, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxIndx_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMax, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxIndx_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMax, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxIndx_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMax, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxIndx_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMax, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, int len, [NativeTypeName("Ipp8u *")] byte* pMin, int* pMinIndx, [NativeTypeName("Ipp8u *")] byte* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc, int len, [NativeTypeName("Ipp16u *")] ushort* pMin, int* pMinIndx, [NativeTypeName("Ipp16u *")] ushort* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMin, int* pMinIndx, [NativeTypeName("Ipp16s *")] short* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_32u([NativeTypeName("const Ipp32u *")] uint* pSrc, int len, [NativeTypeName("Ipp32u *")] uint* pMin, int* pMinIndx, [NativeTypeName("Ipp32u *")] uint* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMin, int* pMinIndx, [NativeTypeName("Ipp32s *")] int* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMin, int* pMinIndx, [NativeTypeName("Ipp32f *")] float* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinMaxIndx_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMin, int* pMinIndx, [NativeTypeName("Ipp64f *")] double* pMax, int* pMaxIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbsIndx_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMinAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbsIndx_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMinAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbsIndx_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMinAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinAbsIndx_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMinAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbsIndx_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMaxAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbsIndx_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMaxAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbsIndx_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMaxAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxAbsIndx_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMaxAbs, int* pIndx);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMean, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int len, Ipp16sc* pMean, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMean, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMean, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, Ipp32fc* pMean, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMean);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMean_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, Ipp64fc* pMean);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsStdDev_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pStdDev, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsStdDev_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pStdDev, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsStdDev_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pStdDev, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsStdDev_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pStdDev);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMeanStdDev_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pMean, [NativeTypeName("Ipp16s *")] short* pStdDev, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMeanStdDev_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pMean, [NativeTypeName("Ipp32s *")] int* pStdDev, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMeanStdDev_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pMean, [NativeTypeName("Ipp32f *")] float* pStdDev, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMeanStdDev_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pMean, [NativeTypeName("Ipp64f *")] double* pStdDev);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_32fc32f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_Inf_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_16s64s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp64s *")] long* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_32fc64f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L1_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_32fc64f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNorm_L2Sqr_16s64s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp64s *")] long* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_32fc32f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_Inf_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_16s64s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp64s *")] long* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_32fc64f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L1_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_32fc64f([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2_64fc64f([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pNorm);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsNormDiff_L2Sqr_16s64s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp64s *")] long* pNorm, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pDp, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16s64s([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp64s *")] long* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16sc64sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, int len, Ipp64sc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16s16sc64sc([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc2, int len, Ipp64sc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16s32s32s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pDp, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc1, [NativeTypeName("const Ipp16s *")] short* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc1, [NativeTypeName("const Ipp32s *")] int* pSrc2, int len, [NativeTypeName("Ipp32s *")] int* pDp, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, int len, [NativeTypeName("Ipp32f *")] float* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, Ipp32fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32f32fc([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, Ipp32fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32f32fc64fc([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, Ipp64fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32f64f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_32fc64fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int len, Ipp64fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, int len, [NativeTypeName("Ipp64f *")] double* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int len, Ipp64fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDotProd_64f64fc([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int len, Ipp64fc* pDp);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_8u_I([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_16u_I([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_16s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_32s_I([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_8u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMinEvery_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_8u_I([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_16u_I([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp16u *")] ushort* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_16s_I([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_32s_I([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_8u([NativeTypeName("const Ipp8u *")] byte* pSrc1, [NativeTypeName("const Ipp8u *")] byte* pSrc2, [NativeTypeName("Ipp8u *")] byte* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_16u([NativeTypeName("const Ipp16u *")] ushort* pSrc1, [NativeTypeName("const Ipp16u *")] ushort* pSrc2, [NativeTypeName("Ipp16u *")] ushort* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxEvery_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("Ipp32u")] uint len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxOrder_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, int* pOrder);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxOrder_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, int* pOrder);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxOrder_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, int* pOrder);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMaxOrder_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, int* pOrder);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCountInRange_32s([NativeTypeName("const Ipp32s *")] int* pSrc, int len, int* pCounts, [NativeTypeName("Ipp32s")] int lowerBound, [NativeTypeName("Ipp32s")] int upperBound);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZeroCrossing_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32u")] uint len, [NativeTypeName("Ipp32f *")] float* pValZCR, IppsZCType zcType);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsZeroCrossing_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32u")] uint len, [NativeTypeName("Ipp32f *")] float* pValZCR, IppsZCType zcType);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int srcLen, [NativeTypeName("Ipp16s *")] short* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int srcLen, Ipp16sc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int srcLen, [NativeTypeName("Ipp32f *")] float* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int srcLen, [NativeTypeName("Ipp64f *")] double* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleUp_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int srcLen, [NativeTypeName("Ipp16s *")] short* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int srcLen, Ipp16sc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int srcLen, [NativeTypeName("Ipp32f *")] float* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int srcLen, [NativeTypeName("Ipp64f *")] double* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSampleDown_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int* pDstLen, int factor, int* pPhase);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAutoCorrNormGetBufferSize(int srcLen, int dstLen, IppDataType dataType, [NativeTypeName("IppEnum")] int algType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAutoCorrNorm_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int srcLen, [NativeTypeName("Ipp32f *")] float* pDst, int dstLen, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAutoCorrNorm_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int srcLen, [NativeTypeName("Ipp64f *")] double* pDst, int dstLen, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAutoCorrNorm_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int srcLen, Ipp32fc* pDst, int dstLen, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsAutoCorrNorm_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int srcLen, Ipp64fc* pDst, int dstLen, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCrossCorrNormGetBufferSize(int src1Len, int src2Len, int dstLen, int lowLag, IppDataType dataType, [NativeTypeName("IppEnum")] int algType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCrossCorrNorm_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, int src1Len, [NativeTypeName("const Ipp32f *")] float* pSrc2, int src2Len, [NativeTypeName("Ipp32f *")] float* pDst, int dstLen, int lowLag, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCrossCorrNorm_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, int src1Len, [NativeTypeName("const Ipp64f *")] double* pSrc2, int src2Len, [NativeTypeName("Ipp64f *")] double* pDst, int dstLen, int lowLag, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCrossCorrNorm_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc1, int src1Len, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc2, int src2Len, Ipp32fc* pDst, int dstLen, int lowLag, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsCrossCorrNorm_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc1, int src1Len, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc2, int src2Len, Ipp64fc* pDst, int dstLen, int lowLag, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvolveGetBufferSize(int src1Len, int src2Len, IppDataType dataType, [NativeTypeName("IppEnum")] int algType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvolve_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, int src1Len, [NativeTypeName("const Ipp32f *")] float* pSrc2, int src2Len, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvolve_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, int src1Len, [NativeTypeName("const Ipp64f *")] double* pSrc2, int src2Len, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("IppEnum")] int algType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsConvBiased_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, int src1Len, [NativeTypeName("const Ipp32f *")] float* pSrc2, int src2Len, [NativeTypeName("Ipp32f *")] float* pDst, int dstLen, int bias);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumWindow_8u32f([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, int maskSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsSumWindow_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, int maskSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRGetSize(int tapsLen, IppDataType tapsType, int* pSpecSize, int* pBufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRGetSize32f_32fc(int tapsLen, int* pSpecSize, int* pBufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRInit_32f([NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, IppAlgType algType, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRInit_64f([NativeTypeName("const Ipp64f *")] double* pTaps, int tapsLen, IppAlgType algType, [NativeTypeName("IppsFIRSpec_64f *")] FIRSpec_64f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRInit_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int tapsLen, IppAlgType algType, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRInit_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int tapsLen, IppAlgType algType, [NativeTypeName("IppsFIRSpec_64fc *")] FIRSpec_64fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSRInit32f_32fc([NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, IppAlgType algType, [NativeTypeName("IppsFIRSpec32f_32fc *")] FIRSpec32f_32fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec, [NativeTypeName("const Ipp16s *")] short* pDlySrc, [NativeTypeName("Ipp16s *")] short* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pDlySrc, Ipp16sc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec, [NativeTypeName("const Ipp32f *")] float* pDlySrc, [NativeTypeName("Ipp32f *")] float* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int numIters, [NativeTypeName("IppsFIRSpec_64f *")] FIRSpec_64f* pSpec, [NativeTypeName("const Ipp64f *")] double* pDlySrc, [NativeTypeName("Ipp64f *")] double* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlySrc, Ipp32fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_64fc *")] FIRSpec_64fc* pSpec, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlySrc, Ipp64fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSR32f_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec32f_32fc *")] FIRSpec32f_32fc* pSpec, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlySrc, Ipp32fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRGetSize(int tapsLen, int upFactor, int downFactor, IppDataType tapsType, int* pSpecSize, int* pBufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRGetSize32f_32fc(int tapsLen, int upFactor, int downFactor, int* pSpecSize, int* pBufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRInit_32f([NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRInit_64f([NativeTypeName("const Ipp64f *")] double* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, [NativeTypeName("IppsFIRSpec_64f *")] FIRSpec_64f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRInit_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRInit_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, [NativeTypeName("IppsFIRSpec_64fc *")] FIRSpec_64fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMRInit32f_32fc([NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, int upFactor, int upPhase, int downFactor, int downPhase, [NativeTypeName("IppsFIRSpec32f_32fc *")] FIRSpec32f_32fc* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec, [NativeTypeName("const Ipp16s *")] short* pDlySrc, [NativeTypeName("Ipp16s *")] short* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_16sc([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec, [NativeTypeName("const Ipp16sc *")] Ipp16sc* pDlySrc, Ipp16sc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32f *")] FIRSpec_32f* pSpec, [NativeTypeName("const Ipp32f *")] float* pDlySrc, [NativeTypeName("Ipp32f *")] float* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int numIters, [NativeTypeName("IppsFIRSpec_64f *")] FIRSpec_64f* pSpec, [NativeTypeName("const Ipp64f *")] double* pDlySrc, [NativeTypeName("Ipp64f *")] double* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_32fc *")] FIRSpec_32fc* pSpec, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlySrc, Ipp32fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec_64fc *")] FIRSpec_64fc* pSpec, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlySrc, Ipp64fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRMR32f_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int numIters, [NativeTypeName("IppsFIRSpec32f_32fc *")] FIRSpec32f_32fc* pSpec, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlySrc, Ipp32fc* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseGetStateSize_32f(int nzTapsLen, int order, int* pStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseInit_32f([NativeTypeName("IppsFIRSparseState_32f **")] FIRSparseState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pNZTaps, [NativeTypeName("const Ipp32s *")] int* pNZTapPos, int nzTapsLen, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseGetStateSize_32fc(int nzTapsLen, int order, int* pStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseInit_32fc([NativeTypeName("IppsFIRSparseState_32fc **")] FIRSparseState_32fc** ppState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pNZTaps, [NativeTypeName("const Ipp32s *")] int* pNZTapPos, int nzTapsLen, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparse_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsFIRSparseState_32f *")] FIRSparseState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparse_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("IppsFIRSparseState_32fc *")] FIRSparseState_32fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseSetDlyLine_32f([NativeTypeName("IppsFIRSparseState_32f *")] FIRSparseState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseGetDlyLine_32f([NativeTypeName("const IppsFIRSparseState_32f *")] FIRSparseState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseSetDlyLine_32fc([NativeTypeName("IppsFIRSparseState_32fc *")] FIRSparseState_32fc* pState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRSparseGetDlyLine_32fc([NativeTypeName("const IppsFIRSparseState_32fc *")] FIRSparseState_32fc* pState, Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRGenGetBufferSize(int tapsLen, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRGenLowpass_64f([NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f *")] double* pTaps, int tapsLen, IppWinType winType, IppBool doNormal, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRGenHighpass_64f([NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f *")] double* pTaps, int tapsLen, IppWinType winType, IppBool doNormal, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRGenBandpass_64f([NativeTypeName("Ipp64f")] double rLowFreq, [NativeTypeName("Ipp64f")] double rHighFreq, [NativeTypeName("Ipp64f *")] double* pTaps, int tapsLen, IppWinType winType, IppBool doNormal, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRGenBandstop_64f([NativeTypeName("Ipp64f")] double rLowFreq, [NativeTypeName("Ipp64f")] double rHighFreq, [NativeTypeName("Ipp64f *")] double* pTaps, int tapsLen, IppWinType winType, IppBool doNormal, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetStateSize32f_16s(int tapsLen, int dlyIndex, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetStateSize_32f(int tapsLen, int dlyIndex, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSInit32f_16s([NativeTypeName("IppsFIRLMSState32f_16s **")] FIRLMSState32f_16s** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, [NativeTypeName("const Ipp16s *")] short* pDlyLine, int dlyIndex, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSInit_32f([NativeTypeName("IppsFIRLMSState_32f **")] FIRLMSState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int tapsLen, [NativeTypeName("const Ipp32f *")] float* pDlyLine, int dlyIndex, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMS32f_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("const Ipp16s *")] short* pRef, [NativeTypeName("Ipp16s *")] short* pDst, int len, float mu, [NativeTypeName("IppsFIRLMSState32f_16s *")] FIRLMSState32f_16s* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMS_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("const Ipp32f *")] float* pRef, [NativeTypeName("Ipp32f *")] float* pDst, int len, float mu, [NativeTypeName("IppsFIRLMSState_32f *")] FIRLMSState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetTaps32f_16s([NativeTypeName("const IppsFIRLMSState32f_16s *")] FIRLMSState32f_16s* pState, [NativeTypeName("Ipp32f *")] float* pOutTaps);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetTaps_32f([NativeTypeName("const IppsFIRLMSState_32f *")] FIRLMSState_32f* pState, [NativeTypeName("Ipp32f *")] float* pOutTaps);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetDlyLine32f_16s([NativeTypeName("const IppsFIRLMSState32f_16s *")] FIRLMSState32f_16s* pState, [NativeTypeName("Ipp16s *")] short* pDlyLine, int* pDlyLineIndex);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSGetDlyLine_32f([NativeTypeName("const IppsFIRLMSState_32f *")] FIRLMSState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLine, int* pDlyLineIndex);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSSetDlyLine32f_16s([NativeTypeName("IppsFIRLMSState32f_16s *")] FIRLMSState32f_16s* pState, [NativeTypeName("const Ipp16s *")] short* pDlyLine, int dlyLineIndex);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFIRLMSSetDlyLine_32f([NativeTypeName("IppsFIRLMSState_32f *")] FIRLMSState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLine, int dlyLineIndex);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine32f_16s([NativeTypeName("const IppsIIRState32f_16s *")] IIRState32f_16s* pState, [NativeTypeName("Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine32fc_16sc([NativeTypeName("const IppsIIRState32fc_16sc *")] IIRState32fc_16sc* pState, Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine_32f([NativeTypeName("const IppsIIRState_32f *")] IIRState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine_32fc([NativeTypeName("const IppsIIRState_32fc *")] IIRState_32fc* pState, Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64f_16s([NativeTypeName("const IppsIIRState64f_16s *")] IIRState64f_16s* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64fc_16sc([NativeTypeName("const IppsIIRState64fc_16sc *")] IIRState64fc_16sc* pState, Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64f_32s([NativeTypeName("const IppsIIRState64f_32s *")] IIRState64f_32s* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64fc_32sc([NativeTypeName("const IppsIIRState64fc_32sc *")] IIRState64fc_32sc* pState, Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64f_DF1_32s([NativeTypeName("const IppsIIRState64f_32s *")] IIRState64f_32s* pState, [NativeTypeName("Ipp32s *")] int* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64f_32f([NativeTypeName("const IppsIIRState64f_32f *")] IIRState64f_32f* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine64fc_32fc([NativeTypeName("const IppsIIRState64fc_32fc *")] IIRState64fc_32fc* pState, Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine_64f([NativeTypeName("const IppsIIRState_64f *")] IIRState_64f* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetDlyLine_64fc([NativeTypeName("const IppsIIRState_64fc *")] IIRState_64fc* pState, Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine32f_16s([NativeTypeName("IppsIIRState32f_16s *")] IIRState32f_16s* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine32fc_16sc([NativeTypeName("IppsIIRState32fc_16sc *")] IIRState32fc_16sc* pState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine_32f([NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine_32fc([NativeTypeName("IppsIIRState_32fc *")] IIRState_32fc* pState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64f_16s([NativeTypeName("IppsIIRState64f_16s *")] IIRState64f_16s* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64fc_16sc([NativeTypeName("IppsIIRState64fc_16sc *")] IIRState64fc_16sc* pState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64f_32s([NativeTypeName("IppsIIRState64f_32s *")] IIRState64f_32s* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64fc_32sc([NativeTypeName("IppsIIRState64fc_32sc *")] IIRState64fc_32sc* pState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64f_DF1_32s([NativeTypeName("IppsIIRState64f_32s *")] IIRState64f_32s* pState, [NativeTypeName("const Ipp32s *")] int* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64f_32f([NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine64fc_32fc([NativeTypeName("IppsIIRState64fc_32fc *")] IIRState64fc_32fc* pState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine_64f([NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSetDlyLine_64fc([NativeTypeName("IppsIIRState_64fc *")] IIRState_64fc* pState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR32f_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("IppsIIRState32f_16s *")] IIRState32f_16s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR32f_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("IppsIIRState32f_16s *")] IIRState32f_16s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR32fc_16sc_ISfs(Ipp16sc* pSrcDst, int len, [NativeTypeName("IppsIIRState32fc_16sc *")] IIRState32fc_16sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR32fc_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("IppsIIRState32fc_16sc *")] IIRState32fc_16sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("IppsIIRState_32fc *")] IIRState_32fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("IppsIIRState_32fc *")] IIRState_32fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_16s_ISfs([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, [NativeTypeName("IppsIIRState64f_16s *")] IIRState64f_16s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, [NativeTypeName("IppsIIRState64f_16s *")] IIRState64f_16s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_16sc_ISfs(Ipp16sc* pSrcDst, int len, [NativeTypeName("IppsIIRState64fc_16sc *")] IIRState64fc_16sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, Ipp16sc* pDst, int len, [NativeTypeName("IppsIIRState64fc_16sc *")] IIRState64fc_16sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32s_ISfs([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, [NativeTypeName("IppsIIRState64f_32s *")] IIRState64f_32s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32s_Sfs([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, [NativeTypeName("IppsIIRState64f_32s *")] IIRState64f_32s* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_32sc_ISfs(Ipp32sc* pSrcDst, int len, [NativeTypeName("IppsIIRState64fc_32sc *")] IIRState64fc_32sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_32sc_Sfs([NativeTypeName("const Ipp32sc *")] Ipp32sc* pSrc, Ipp32sc* pDst, int len, [NativeTypeName("IppsIIRState64fc_32sc *")] IIRState64fc_32sc* pState, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_32fc_I(Ipp32fc* pSrcDst, int len, [NativeTypeName("IppsIIRState64fc_32fc *")] IIRState64fc_32fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64fc_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, int len, [NativeTypeName("IppsIIRState64fc_32fc *")] IIRState64fc_32fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_64fc_I(Ipp64fc* pSrcDst, int len, [NativeTypeName("IppsIIRState_64fc *")] IIRState_64fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, int len, [NativeTypeName("IppsIIRState_64fc *")] IIRState_64fc* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32f_IP([NativeTypeName("Ipp32f **")] float** ppSrcDst, int len, int nChannels, [NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR_32f_P([NativeTypeName("const Ipp32f **")] float** ppSrc, [NativeTypeName("Ipp32f **")] float** ppDst, int len, int nChannels, [NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32s_IPSfs([NativeTypeName("Ipp32s **")] int** ppSrcDst, int len, int nChannels, [NativeTypeName("IppsIIRState64f_32s **")] IIRState64f_32s** ppState, int* pScaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIR64f_32s_PSfs([NativeTypeName("const Ipp32s **")] int** ppSrc, [NativeTypeName("Ipp32s **")] int** ppDst, int len, int nChannels, [NativeTypeName("IppsIIRState64f_32s **")] IIRState64f_32s** ppState, int* pScaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize32f_16s(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize32fc_16sc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_32f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_32fc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_16s(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_16sc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_32s(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_32sc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_32f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_32fc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_64f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_64fc(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize32f_BiQuad_16s(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize32fc_BiQuad_16sc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_BiQuad_32f(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_BiQuad_DF1_32f(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_BiQuad_32fc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_BiQuad_16s(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_BiQuad_16sc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_BiQuad_32s(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_BiQuad_DF1_32s(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_BiQuad_32sc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64f_BiQuad_32f(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize64fc_BiQuad_32fc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_BiQuad_64f(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGetStateSize_BiQuad_64fc(int numBq, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit32f_16s([NativeTypeName("IppsIIRState32f_16s **")] IIRState32f_16s** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int order, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit32fc_16sc([NativeTypeName("IppsIIRState32fc_16sc **")] IIRState32fc_16sc** ppState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int order, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_32f([NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int order, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_32fc([NativeTypeName("IppsIIRState_32fc **")] IIRState_32fc** ppState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int order, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_16s([NativeTypeName("IppsIIRState64f_16s **")] IIRState64f_16s** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_16sc([NativeTypeName("IppsIIRState64fc_16sc **")] IIRState64fc_16sc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int order, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_32s([NativeTypeName("IppsIIRState64f_32s **")] IIRState64f_32s** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_32sc([NativeTypeName("IppsIIRState64fc_32sc **")] IIRState64fc_32sc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int order, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_32f([NativeTypeName("IppsIIRState64f_32f **")] IIRState64f_32f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_32fc([NativeTypeName("IppsIIRState64fc_32fc **")] IIRState64fc_32fc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int order, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_64f([NativeTypeName("IppsIIRState_64f **")] IIRState_64f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_64fc([NativeTypeName("IppsIIRState_64fc **")] IIRState_64fc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int order, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit32f_BiQuad_16s([NativeTypeName("IppsIIRState32f_16s **")] IIRState32f_16s** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int numBq, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit32fc_BiQuad_16sc([NativeTypeName("IppsIIRState32fc_16sc **")] IIRState32fc_16sc** ppState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int numBq, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_BiQuad_32f([NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int numBq, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_BiQuad_DF1_32f([NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int numBq, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_BiQuad_32fc([NativeTypeName("IppsIIRState_32fc **")] IIRState_32fc** ppState, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pTaps, int numBq, [NativeTypeName("const Ipp32fc *")] Ipp32fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_BiQuad_16s([NativeTypeName("IppsIIRState64f_16s **")] IIRState64f_16s** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int numBq, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_BiQuad_16sc([NativeTypeName("IppsIIRState64fc_16sc **")] IIRState64fc_16sc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int numBq, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_BiQuad_32s([NativeTypeName("IppsIIRState64f_32s **")] IIRState64f_32s** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int numBq, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_BiQuad_DF1_32s([NativeTypeName("IppsIIRState64f_32s **")] IIRState64f_32s** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int numBq, [NativeTypeName("const Ipp32s *")] int* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_BiQuad_32sc([NativeTypeName("IppsIIRState64fc_32sc **")] IIRState64fc_32sc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int numBq, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64f_BiQuad_32f([NativeTypeName("IppsIIRState64f_32f **")] IIRState64f_32f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int numBq, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit64fc_BiQuad_32fc([NativeTypeName("IppsIIRState64fc_32fc **")] IIRState64fc_32fc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int numBq, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_BiQuad_64f([NativeTypeName("IppsIIRState_64f **")] IIRState_64f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int numBq, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRInit_BiQuad_64fc([NativeTypeName("IppsIIRState_64fc **")] IIRState_64fc** ppState, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pTaps, int numBq, [NativeTypeName("const Ipp64fc *")] Ipp64fc* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSparseGetStateSize_32f(int nzTapsLen1, int nzTapsLen2, int order1, int order2, int* pStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSparseInit_32f([NativeTypeName("IppsIIRSparseState_32f **")] IIRSparseState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pNZTaps, [NativeTypeName("const Ipp32s *")] int* pNZTapPos, int nzTapsLen1, int nzTapsLen2, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRSparse_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsIIRSparseState_32f *")] IIRSparseState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGenLowpass_64f([NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f")] double ripple, int order, [NativeTypeName("Ipp64f *")] double* pTaps, IppsIIRFilterType filterType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGenHighpass_64f([NativeTypeName("Ipp64f")] double rFreq, [NativeTypeName("Ipp64f")] double ripple, int order, [NativeTypeName("Ipp64f *")] double* pTaps, IppsIIRFilterType filterType, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRGenGetBufferSize(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedianGetBufferSize(int maskSize, IppDataType dataType, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_8u_I([NativeTypeName("Ipp8u *")] byte* pSrcDst, int len, int maskSize, [NativeTypeName("const Ipp8u *")] byte* pDlySrc, [NativeTypeName("Ipp8u *")] byte* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_8u([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp8u *")] byte* pDst, int len, int maskSize, [NativeTypeName("const Ipp8u *")] byte* pDlySrc, [NativeTypeName("Ipp8u *")] byte* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_16s_I([NativeTypeName("Ipp16s *")] short* pSrcDst, int len, int maskSize, [NativeTypeName("const Ipp16s *")] short* pDlySrc, [NativeTypeName("Ipp16s *")] short* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_16s([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp16s *")] short* pDst, int len, int maskSize, [NativeTypeName("const Ipp16s *")] short* pDlySrc, [NativeTypeName("Ipp16s *")] short* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_32s_I([NativeTypeName("Ipp32s *")] int* pSrcDst, int len, int maskSize, [NativeTypeName("const Ipp32s *")] int* pDlySrc, [NativeTypeName("Ipp32s *")] int* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp32s *")] int* pDst, int len, int maskSize, [NativeTypeName("const Ipp32s *")] int* pDlySrc, [NativeTypeName("Ipp32s *")] int* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, int maskSize, [NativeTypeName("const Ipp32f *")] float* pDlySrc, [NativeTypeName("Ipp32f *")] float* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, int maskSize, [NativeTypeName("const Ipp32f *")] float* pDlySrc, [NativeTypeName("Ipp32f *")] float* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, int maskSize, [NativeTypeName("const Ipp64f *")] double* pDlySrc, [NativeTypeName("Ipp64f *")] double* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFilterMedian_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, int maskSize, [NativeTypeName("const Ipp64f *")] double* pDlySrc, [NativeTypeName("Ipp64f *")] double* pDlyDst, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphase_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pDst, [NativeTypeName("Ipp64f")] double factor, [NativeTypeName("Ipp32f")] float norm, [NativeTypeName("Ipp64f *")] double* pTime, int* pOutlen, [NativeTypeName("const IppsResamplingPolyphase_16s *")] ResamplingPolyphase_16s* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphase_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("Ipp64f")] double factor, [NativeTypeName("Ipp32f")] float norm, [NativeTypeName("Ipp64f *")] double* pTime, int* pOutlen, [NativeTypeName("const IppsResamplingPolyphase_32f *")] ResamplingPolyphase_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixed_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pDst, [NativeTypeName("Ipp32f")] float norm, [NativeTypeName("Ipp64f *")] double* pTime, int* pOutlen, [NativeTypeName("const IppsResamplingPolyphaseFixed_16s *")] ResamplingPolyphaseFixed_16s* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixed_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("Ipp32f")] float norm, [NativeTypeName("Ipp64f *")] double* pTime, int* pOutlen, [NativeTypeName("const IppsResamplingPolyphaseFixed_32f *")] ResamplingPolyphaseFixed_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseGetSize_16s([NativeTypeName("Ipp32f")] float window, int nStep, int* pSize, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseGetSize_32f([NativeTypeName("Ipp32f")] float window, int nStep, int* pSize, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixedGetSize_16s(int inRate, int outRate, int len, int* pSize, int* pLen, int* pHeight, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixedGetSize_32f(int inRate, int outRate, int len, int* pSize, int* pLen, int* pHeight, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseInit_16s([NativeTypeName("Ipp32f")] float window, int nStep, [NativeTypeName("Ipp32f")] float rollf, [NativeTypeName("Ipp32f")] float alpha, [NativeTypeName("IppsResamplingPolyphase_16s *")] ResamplingPolyphase_16s* pSpec, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseInit_32f([NativeTypeName("Ipp32f")] float window, int nStep, [NativeTypeName("Ipp32f")] float rollf, [NativeTypeName("Ipp32f")] float alpha, [NativeTypeName("IppsResamplingPolyphase_32f *")] ResamplingPolyphase_32f* pSpec, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixedInit_16s(int inRate, int outRate, int len, [NativeTypeName("Ipp32f")] float rollf, [NativeTypeName("Ipp32f")] float alpha, [NativeTypeName("IppsResamplingPolyphaseFixed_16s *")] ResamplingPolyphaseFixed_16s* pSpec, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseFixedInit_32f(int inRate, int outRate, int len, [NativeTypeName("Ipp32f")] float rollf, [NativeTypeName("Ipp32f")] float alpha, [NativeTypeName("IppsResamplingPolyphaseFixed_32f *")] ResamplingPolyphaseFixed_32f* pSpec, IppHintAlgorithm hint);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseSetFixedFilter_16s([NativeTypeName("const Ipp16s *")] short* pSrc, int step, int height, [NativeTypeName("IppsResamplingPolyphaseFixed_16s *")] ResamplingPolyphaseFixed_16s* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseSetFixedFilter_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int step, int height, [NativeTypeName("IppsResamplingPolyphaseFixed_32f *")] ResamplingPolyphaseFixed_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseGetFixedFilter_16s([NativeTypeName("Ipp16s *")] short* pDst, int step, int height, [NativeTypeName("const IppsResamplingPolyphaseFixed_16s *")] ResamplingPolyphaseFixed_16s* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsResamplePolyphaseGetFixedFilter_32f([NativeTypeName("Ipp32f *")] float* pDst, int step, int height, [NativeTypeName("const IppsResamplingPolyphaseFixed_32f *")] ResamplingPolyphaseFixed_32f* pSpec);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetStateSize_32f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetStateSize64f_32f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetStateSize_64f(int order, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRInit64f_32f([NativeTypeName("IppsIIRState64f_32f **")] IIRState64f_32f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRInit_32f([NativeTypeName("IppsIIRState_32f **")] IIRState_32f** ppState, [NativeTypeName("const Ipp32f *")] float* pTaps, int order, [NativeTypeName("const Ipp32f *")] float* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRInit_64f([NativeTypeName("IppsIIRState_64f **")] IIRState_64f** ppState, [NativeTypeName("const Ipp64f *")] double* pTaps, int order, [NativeTypeName("const Ipp64f *")] double* pDlyLine, [NativeTypeName("Ipp8u *")] byte* pBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR64f_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR64f_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, int len, [NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, int len, [NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetDlyLine64f_32f([NativeTypeName("const IppsIIRState64f_32f *")] IIRState64f_32f* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRSetDlyLine64f_32f([NativeTypeName("IppsIIRState64f_32f *")] IIRState64f_32f* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetDlyLine_32f([NativeTypeName("const IppsIIRState_32f *")] IIRState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRSetDlyLine_32f([NativeTypeName("IppsIIRState_32f *")] IIRState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRGetDlyLine_64f([NativeTypeName("const IppsIIRState_64f *")] IIRState_64f* pState, [NativeTypeName("Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsIIRIIRSetDlyLine_64f([NativeTypeName("IppsIIRState_64f *")] IIRState_64f* pState, [NativeTypeName("const Ipp64f *")] double* pDlyLine);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_C_16fc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_C_32f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_R_32f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_C_32fc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_C_64f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_R_64f(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTGetSize_C_64fc(int order, int flag, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_C_16fc([NativeTypeName("IppsFFTSpec_C_16fc **")] FFTSpec_C_16fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_C_32f([NativeTypeName("IppsFFTSpec_C_32f **")] FFTSpec_C_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_R_32f([NativeTypeName("IppsFFTSpec_R_32f **")] FFTSpec_R_32f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_C_32fc([NativeTypeName("IppsFFTSpec_C_32fc **")] FFTSpec_C_32fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_C_64f([NativeTypeName("IppsFFTSpec_C_64f **")] FFTSpec_C_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_R_64f([NativeTypeName("IppsFFTSpec_R_64f **")] FFTSpec_R_64f** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInit_C_64fc([NativeTypeName("IppsFFTSpec_C_64fc **")] FFTSpec_C_64fc** ppFFTSpec, int order, int flag, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, [NativeTypeName("const IppsFFTSpec_C_16fc *")] FFTSpec_C_16fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, [NativeTypeName("const IppsFFTSpec_C_16fc *")] FFTSpec_C_16fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, [NativeTypeName("const IppsFFTSpec_C_32fc *")] FFTSpec_C_32fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, [NativeTypeName("const IppsFFTSpec_C_32fc *")] FFTSpec_C_32fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, [NativeTypeName("const IppsFFTSpec_C_64fc *")] FFTSpec_C_64fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, [NativeTypeName("const IppsFFTSpec_C_64fc *")] FFTSpec_C_64fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_32fc_I(Ipp32fc* pSrcDst, [NativeTypeName("const IppsFFTSpec_C_32fc *")] FFTSpec_C_32fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_32fc_I(Ipp32fc* pSrcDst, [NativeTypeName("const IppsFFTSpec_C_32fc *")] FFTSpec_C_32fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_64fc_I(Ipp64fc* pSrcDst, [NativeTypeName("const IppsFFTSpec_C_64fc *")] FFTSpec_C_64fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_64fc_I(Ipp64fc* pSrcDst, [NativeTypeName("const IppsFFTSpec_C_64fc *")] FFTSpec_C_64fc* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDstRe, [NativeTypeName("Ipp32f *")] float* pSrcDstIm, [NativeTypeName("const IppsFFTSpec_C_32f *")] FFTSpec_C_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDstRe, [NativeTypeName("Ipp32f *")] float* pSrcDstIm, [NativeTypeName("const IppsFFTSpec_C_32f *")] FFTSpec_C_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDstRe, [NativeTypeName("Ipp64f *")] double* pSrcDstIm, [NativeTypeName("const IppsFFTSpec_C_64f *")] FFTSpec_C_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDstRe, [NativeTypeName("Ipp64f *")] double* pSrcDstIm, [NativeTypeName("const IppsFFTSpec_C_64f *")] FFTSpec_C_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, [NativeTypeName("const IppsFFTSpec_C_32f *")] FFTSpec_C_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, [NativeTypeName("const IppsFFTSpec_C_32f *")] FFTSpec_C_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_CToC_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, [NativeTypeName("const IppsFFTSpec_C_64f *")] FFTSpec_C_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CToC_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, [NativeTypeName("const IppsFFTSpec_C_64f *")] FFTSpec_C_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPerm_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPack_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToCCS_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PermToR_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PackToR_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CCSToR_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPerm_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPack_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToCCS_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PermToR_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PackToR_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CCSToR_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPerm_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPack_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToCCS_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PermToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PackToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CCSToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsFFTSpec_R_32f *")] FFTSpec_R_32f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPerm_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToPack_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTFwd_RToCCS_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PermToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_PackToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsFFTInv_CCSToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsFFTSpec_R_64f *")] FFTSpec_R_64f* pFFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_C_16fc(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_C_32f(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_R_32f(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_C_32fc(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_C_64f(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_R_64f(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTGetSize_C_64fc(int length, int flag, IppHintAlgorithm hint, int* pSizeSpec, int* pSizeInit, int* pSizeBuf);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_C_16fc(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_C_16fc *")] DFTSpec_C_16fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_C_32f(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_C_32f *")] DFTSpec_C_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_R_32f(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_C_32fc(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_C_32fc *")] DFTSpec_C_32fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_C_64f(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_C_64f *")] DFTSpec_C_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_R_64f(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInit_C_64fc(int length, int flag, IppHintAlgorithm hint, [NativeTypeName("IppsDFTSpec_C_64fc *")] DFTSpec_C_64fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pMemInit);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, [NativeTypeName("const IppsDFTSpec_C_16fc *")] DFTSpec_C_16fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, [NativeTypeName("const IppsDFTSpec_C_16fc *")] DFTSpec_C_16fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_CToC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, [NativeTypeName("const IppsDFTSpec_C_32fc *")] DFTSpec_C_32fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CToC_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, Ipp32fc* pDst, [NativeTypeName("const IppsDFTSpec_C_32fc *")] DFTSpec_C_32fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_CToC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, [NativeTypeName("const IppsDFTSpec_C_64fc *")] DFTSpec_C_64fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CToC_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, Ipp64fc* pDst, [NativeTypeName("const IppsDFTSpec_C_64fc *")] DFTSpec_C_64fc* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_CToC_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, [NativeTypeName("const IppsDFTSpec_C_32f *")] DFTSpec_C_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CToC_32f([NativeTypeName("const Ipp32f *")] float* pSrcRe, [NativeTypeName("const Ipp32f *")] float* pSrcIm, [NativeTypeName("Ipp32f *")] float* pDstRe, [NativeTypeName("Ipp32f *")] float* pDstIm, [NativeTypeName("const IppsDFTSpec_C_32f *")] DFTSpec_C_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_CToC_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, [NativeTypeName("const IppsDFTSpec_C_64f *")] DFTSpec_C_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CToC_64f([NativeTypeName("const Ipp64f *")] double* pSrcRe, [NativeTypeName("const Ipp64f *")] double* pSrcIm, [NativeTypeName("Ipp64f *")] double* pDstRe, [NativeTypeName("Ipp64f *")] double* pDstIm, [NativeTypeName("const IppsDFTSpec_C_64f *")] DFTSpec_C_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_Direct_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, int length);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_Direct_CToC_16fc([NativeTypeName("const Ipp16fc *")] Ipp16fc* pSrc, Ipp16fc* pDst, int length);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToPerm_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToPack_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToCCS_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_PermToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_PackToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CCSToR_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDFTSpec_R_32f *")] DFTSpec_R_32f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToPerm_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToPack_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTFwd_RToCCS_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_PermToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_PackToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDFTInv_CCSToR_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDFTSpec_R_64f *")] DFTSpec_R_64f* pDFTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPack_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPerm_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPack_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPerm_32f([NativeTypeName("const Ipp32f *")] float* pSrc1, [NativeTypeName("const Ipp32f *")] float* pSrc2, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPack_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPerm_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPack_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPerm_64f([NativeTypeName("const Ipp64f *")] double* pSrc1, [NativeTypeName("const Ipp64f *")] double* pSrc2, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPackConj_32f_I([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsMulPackConj_64f_I([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pSrcDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, Ipp16sc* pVal, [NativeTypeName("Ipp32f")] float rFreq, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_16sc_Sfs([NativeTypeName("const Ipp16sc *")] Ipp16sc* pSrc, int len, Ipp16sc* pVal, [NativeTypeName("Ipp32f")] float rFreq, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, Ipp32fc* pVal, [NativeTypeName("Ipp32f")] float rFreq);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_32fc([NativeTypeName("const Ipp32fc *")] Ipp32fc* pSrc, int len, Ipp32fc* pVal, [NativeTypeName("Ipp32f")] float rFreq);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, Ipp64fc* pVal, [NativeTypeName("Ipp64f")] double rFreq);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsGoertz_64fc([NativeTypeName("const Ipp64fc *")] Ipp64fc* pSrc, int len, Ipp64fc* pVal, [NativeTypeName("Ipp64f")] double rFreq);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwdGetSize_32f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInvGetSize_32f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwdGetSize_64f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInvGetSize_64f(int len, IppHintAlgorithm hint, int* pSpecSize, int* pSpecBufferSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwdInit_32f([NativeTypeName("IppsDCTFwdSpec_32f **")] DCTFwdSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInvInit_32f([NativeTypeName("IppsDCTInvSpec_32f **")] DCTInvSpec_32f** ppDCTSpec, int len, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwdInit_64f([NativeTypeName("IppsDCTFwdSpec_64f **")] DCTFwdSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInvInit_64f([NativeTypeName("IppsDCTInvSpec_64f **")] DCTInvSpec_64f** ppDCTSpec, int len, IppHintAlgorithm hint, [NativeTypeName("Ipp8u *")] byte* pSpec, [NativeTypeName("Ipp8u *")] byte* pSpecBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwd_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsDCTFwdSpec_32f *")] DCTFwdSpec_32f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInv_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, [NativeTypeName("const IppsDCTInvSpec_32f *")] DCTInvSpec_32f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwd_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDCTFwdSpec_32f *")] DCTFwdSpec_32f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInv_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("const IppsDCTInvSpec_32f *")] DCTInvSpec_32f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwd_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsDCTFwdSpec_64f *")] DCTFwdSpec_64f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInv_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, [NativeTypeName("const IppsDCTInvSpec_64f *")] DCTInvSpec_64f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTFwd_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDCTFwdSpec_64f *")] DCTFwdSpec_64f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsDCTInv_64f([NativeTypeName("const Ipp64f *")] double* pSrc, [NativeTypeName("Ipp64f *")] double* pDst, [NativeTypeName("const IppsDCTInvSpec_64f *")] DCTInvSpec_64f* pDCTSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbertGetSize_32f32fc(int length, IppHintAlgorithm hint, int* pSpecSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbertGetSize_64f64fc(int length, IppHintAlgorithm hint, int* pSpecSize, int* pBufferSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbertInit_32f32fc(int length, IppHintAlgorithm hint, [NativeTypeName("IppsHilbertSpec *")] HilbertSpec* pSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbertInit_64f64fc(int length, IppHintAlgorithm hint, [NativeTypeName("IppsHilbertSpec *")] HilbertSpec* pSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbert_32f32fc([NativeTypeName("const Ipp32f *")] float* pSrc, Ipp32fc* pDst, [NativeTypeName("IppsHilbertSpec *")] HilbertSpec* pSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsHilbert_64f64fc([NativeTypeName("const Ipp64f *")] double* pSrc, Ipp64fc* pDst, [NativeTypeName("IppsHilbertSpec *")] HilbertSpec* pSpec, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarFwd_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrc, int len, [NativeTypeName("Ipp16s *")] short* pDstLow, [NativeTypeName("Ipp16s *")] short* pDstHigh, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarFwd_32f([NativeTypeName("const Ipp32f *")] float* pSrc, int len, [NativeTypeName("Ipp32f *")] float* pDstLow, [NativeTypeName("Ipp32f *")] float* pDstHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarFwd_64f([NativeTypeName("const Ipp64f *")] double* pSrc, int len, [NativeTypeName("Ipp64f *")] double* pDstLow, [NativeTypeName("Ipp64f *")] double* pDstHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarInv_16s_Sfs([NativeTypeName("const Ipp16s *")] short* pSrcLow, [NativeTypeName("const Ipp16s *")] short* pSrcHigh, [NativeTypeName("Ipp16s *")] short* pDst, int len, int scaleFactor);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarInv_32f([NativeTypeName("const Ipp32f *")] float* pSrcLow, [NativeTypeName("const Ipp32f *")] float* pSrcHigh, [NativeTypeName("Ipp32f *")] float* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTHaarInv_64f([NativeTypeName("const Ipp64f *")] double* pSrcLow, [NativeTypeName("const Ipp64f *")] double* pSrcHigh, [NativeTypeName("Ipp64f *")] double* pDst, int len);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdGetSize(IppDataType srcType, int lenLow, int offsLow, int lenHigh, int offsHigh, int* pStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdInit_8u32f([NativeTypeName("IppsWTFwdState_8u32f *")] sWTFwdState_8u32f* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdInit_16s32f([NativeTypeName("IppsWTFwdState_16s32f *")] sWTFwdState_16s32f* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdInit_16u32f([NativeTypeName("IppsWTFwdState_16u32f *")] sWTFwdState_16u32f* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdInit_32f([NativeTypeName("IppsWTFwdState_32f *")] sWTFwdState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdSetDlyLine_8u32f([NativeTypeName("IppsWTFwdState_8u32f *")] sWTFwdState_8u32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdSetDlyLine_16s32f([NativeTypeName("IppsWTFwdState_16s32f *")] sWTFwdState_16s32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdSetDlyLine_16u32f([NativeTypeName("IppsWTFwdState_16u32f *")] sWTFwdState_16u32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdSetDlyLine_32f([NativeTypeName("IppsWTFwdState_32f *")] sWTFwdState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdGetDlyLine_8u32f([NativeTypeName("IppsWTFwdState_8u32f *")] sWTFwdState_8u32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdGetDlyLine_16s32f([NativeTypeName("IppsWTFwdState_16s32f *")] sWTFwdState_16s32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdGetDlyLine_16u32f([NativeTypeName("IppsWTFwdState_16u32f *")] sWTFwdState_16u32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwdGetDlyLine_32f([NativeTypeName("IppsWTFwdState_32f *")] sWTFwdState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwd_8u32f([NativeTypeName("const Ipp8u *")] byte* pSrc, [NativeTypeName("Ipp32f *")] float* pDstLow, [NativeTypeName("Ipp32f *")] float* pDstHigh, int dstLen, [NativeTypeName("IppsWTFwdState_8u32f *")] sWTFwdState_8u32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwd_16s32f([NativeTypeName("const Ipp16s *")] short* pSrc, [NativeTypeName("Ipp32f *")] float* pDstLow, [NativeTypeName("Ipp32f *")] float* pDstHigh, int dstLen, [NativeTypeName("IppsWTFwdState_16s32f *")] sWTFwdState_16s32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwd_16u32f([NativeTypeName("const Ipp16u *")] ushort* pSrc, [NativeTypeName("Ipp32f *")] float* pDstLow, [NativeTypeName("Ipp32f *")] float* pDstHigh, int dstLen, [NativeTypeName("IppsWTFwdState_16u32f *")] sWTFwdState_16u32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTFwd_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp32f *")] float* pDstLow, [NativeTypeName("Ipp32f *")] float* pDstHigh, int dstLen, [NativeTypeName("IppsWTFwdState_32f *")] sWTFwdState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvGetSize(IppDataType dstType, int lenLow, int offsLow, int lenHigh, int offsHigh, int* pStateSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvInit_32f8u([NativeTypeName("IppsWTInvState_32f8u *")] sWTInvState_32f8u* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvInit_32f16u([NativeTypeName("IppsWTInvState_32f16u *")] sWTInvState_32f16u* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvInit_32f16s([NativeTypeName("IppsWTInvState_32f16s *")] sWTInvState_32f16s* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvInit_32f([NativeTypeName("IppsWTInvState_32f *")] sWTInvState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pTapsLow, int lenLow, int offsLow, [NativeTypeName("const Ipp32f *")] float* pTapsHigh, int lenHigh, int offsHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvSetDlyLine_32f8u([NativeTypeName("IppsWTInvState_32f8u *")] sWTInvState_32f8u* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvSetDlyLine_32f16s([NativeTypeName("IppsWTInvState_32f16s *")] sWTInvState_32f16s* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvSetDlyLine_32f16u([NativeTypeName("IppsWTInvState_32f16u *")] sWTInvState_32f16u* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvSetDlyLine_32f([NativeTypeName("IppsWTInvState_32f *")] sWTInvState_32f* pState, [NativeTypeName("const Ipp32f *")] float* pDlyLow, [NativeTypeName("const Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvGetDlyLine_32f8u([NativeTypeName("IppsWTInvState_32f8u *")] sWTInvState_32f8u* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvGetDlyLine_32f16s([NativeTypeName("IppsWTInvState_32f16s *")] sWTInvState_32f16s* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvGetDlyLine_32f16u([NativeTypeName("IppsWTInvState_32f16u *")] sWTInvState_32f16u* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInvGetDlyLine_32f([NativeTypeName("IppsWTInvState_32f *")] sWTInvState_32f* pState, [NativeTypeName("Ipp32f *")] float* pDlyLow, [NativeTypeName("Ipp32f *")] float* pDlyHigh);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInv_32f8u([NativeTypeName("const Ipp32f *")] float* pSrcLow, [NativeTypeName("const Ipp32f *")] float* pSrcHigh, int srcLen, [NativeTypeName("Ipp8u *")] byte* pDst, [NativeTypeName("IppsWTInvState_32f8u *")] sWTInvState_32f8u* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInv_32f16s([NativeTypeName("const Ipp32f *")] float* pSrcLow, [NativeTypeName("const Ipp32f *")] float* pSrcHigh, int srcLen, [NativeTypeName("Ipp16s *")] short* pDst, [NativeTypeName("IppsWTInvState_32f16s *")] sWTInvState_32f16s* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInv_32f16u([NativeTypeName("const Ipp32f *")] float* pSrcLow, [NativeTypeName("const Ipp32f *")] float* pSrcHigh, int srcLen, [NativeTypeName("Ipp16u *")] ushort* pDst, [NativeTypeName("IppsWTInvState_32f16u *")] sWTInvState_32f16u* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsWTInv_32f([NativeTypeName("const Ipp32f *")] float* pSrcLow, [NativeTypeName("const Ipp32f *")] float* pSrcHigh, int srcLen, [NativeTypeName("Ipp32f *")] float* pDst, [NativeTypeName("IppsWTInvState_32f *")] sWTInvState_32f* pState);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsReplaceNAN_32f_I([NativeTypeName("Ipp32f *")] float* pSrcDst, int len, [NativeTypeName("Ipp32f")] float value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsReplaceNAN_64f_I([NativeTypeName("Ipp64f *")] double* pSrcDst, int len, [NativeTypeName("Ipp64f")] double value);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPatternMatchGetBufferSize(int srcLen, int patternLen, int patternSize, IppPatternMatchMode hint, int* bufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsPatternMatch_8u16u([NativeTypeName("const Ipp8u *")] byte* pSrc, int srcStep, int srcLen, [NativeTypeName("const Ipp8u *")] byte* pPattern, int patternStep, int patternLen, int patternSize, [NativeTypeName("Ipp16u *")] ushort* pDst, IppPatternMatchMode hint, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTopKGetBufferSize([NativeTypeName("Ipp64s")] long srcLen, [NativeTypeName("Ipp64s")] long dstLen, IppDataType dataType, IppTopKMode hint, [NativeTypeName("Ipp64s *")] long* bufSize);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTopKInit_32s([NativeTypeName("Ipp32s *")] int* pDstValue, [NativeTypeName("Ipp64s *")] long* pDstIndex, [NativeTypeName("Ipp64s")] long dstLen);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTopKInit_32f([NativeTypeName("Ipp32f *")] float* pDstValue, [NativeTypeName("Ipp64s *")] long* pDstIndex, [NativeTypeName("Ipp64s")] long dstLen);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTopK_32s([NativeTypeName("const Ipp32s *")] int* pSrc, [NativeTypeName("Ipp64s")] long srcIndex, [NativeTypeName("Ipp64s")] long srcStride, [NativeTypeName("Ipp64s")] long srcLen, [NativeTypeName("Ipp32s *")] int* pDstValue, [NativeTypeName("Ipp64s *")] long* pDstIndex, [NativeTypeName("Ipp64s")] long dstLen, IppTopKMode hint, [NativeTypeName("Ipp8u *")] byte* pBuffer);

        [DllImport("ipps.dll", CallingConvention = CallingConvention.StdCall, ExactSpelling = true)]
        [return: NativeTypeName("IppStatus")]
        public static extern int ippsTopK_32f([NativeTypeName("const Ipp32f *")] float* pSrc, [NativeTypeName("Ipp64s")] long srcIndex, [NativeTypeName("Ipp64s")] long srcStride, [NativeTypeName("Ipp64s")] long srcLen, [NativeTypeName("Ipp32f *")] float* pDstValue, [NativeTypeName("Ipp64s *")] long* pDstIndex, [NativeTypeName("Ipp64s")] long dstLen, IppTopKMode hint, [NativeTypeName("Ipp8u *")] byte* pBuffer);
    }
}
