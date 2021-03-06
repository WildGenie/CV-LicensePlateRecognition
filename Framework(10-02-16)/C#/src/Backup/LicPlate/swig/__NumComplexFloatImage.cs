/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class __NumComplexFloatImage : Image {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;

  internal __NumComplexFloatImage(global::System.IntPtr cPtr, bool cMemoryOwn) : base(VisionLabPINVOKE.__NumComplexFloatImage_SWIGUpcast(cPtr), cMemoryOwn) {
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(__NumComplexFloatImage obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~__NumComplexFloatImage() {
    Dispose();
  }

  public override void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete___NumComplexFloatImage(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
      base.Dispose();
    }
  }

  public __NumComplexFloatImage() : this(VisionLabPINVOKE.new___NumComplexFloatImage__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumComplexFloatImage(int height, int width) : this(VisionLabPINVOKE.new___NumComplexFloatImage__SWIG_1(height, width), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumComplexFloatImage(HeightWidth hw) : this(VisionLabPINVOKE.new___NumComplexFloatImage__SWIG_2(HeightWidth.getCPtr(hw)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public __NumComplexFloatImage(__NumComplexFloatImage image) : this(VisionLabPINVOKE.new___NumComplexFloatImage__SWIG_3(__NumComplexFloatImage.getCPtr(image)), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Clear() {
    VisionLabPINVOKE.__NumComplexFloatImage_Clear(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width, bool deleteOrg) {
    VisionLabPINVOKE.__NumComplexFloatImage_SetBuf__SWIG_0(swigCPtr, buf, height, width, deleteOrg);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void SetBuf(string buf, int height, int width) {
    VisionLabPINVOKE.__NumComplexFloatImage_SetBuf__SWIG_1(swigCPtr, buf, height, width);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void Resize(HeightWidth hw) {
    VisionLabPINVOKE.__NumComplexFloatImage_Resize__SWIG_0(swigCPtr, HeightWidth.getCPtr(hw));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual void Resize(HeightWidth hw, __NumComplexFloatImage properties) {
    VisionLabPINVOKE.__NumComplexFloatImage_Resize__SWIG_1(swigCPtr, HeightWidth.getCPtr(hw), __NumComplexFloatImage.getCPtr(properties));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadAsciiFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumComplexFloatImage_ReadAsciiFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteAsciiToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumComplexFloatImage_WriteAsciiToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void ReadBinFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.__NumComplexFloatImage_ReadBinFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public override void WriteBinToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.__NumComplexFloatImage_WriteBinToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_std__complexT_float_t GetFirstPixelPtr() {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumComplexFloatImage_GetFirstPixelPtr(swigCPtr);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetLastPixelPtr() {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumComplexFloatImage_GetLastPixelPtr(swigCPtr);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumComplexFloatImage Assign_Op(__NumComplexFloatImage image) {
    __NumComplexFloatImage ret = new __NumComplexFloatImage(VisionLabPINVOKE.__NumComplexFloatImage_Assign_Op__SWIG_0(swigCPtr, __NumComplexFloatImage.getCPtr(image)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public __NumComplexFloatImage Assign_Op(SWIGTYPE_p_std__complexT_float_t pixel) {
    __NumComplexFloatImage ret = new __NumComplexFloatImage(VisionLabPINVOKE.__NumComplexFloatImage_Assign_Op__SWIG_1(swigCPtr, SWIGTYPE_p_std__complexT_float_t.getCPtr(pixel)), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool IsEqual_Op(__NumComplexFloatImage image) {
    bool ret = VisionLabPINVOKE.__NumComplexFloatImage_IsEqual_Op(swigCPtr, __NumComplexFloatImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool Not(__NumComplexFloatImage image) {
    bool ret = VisionLabPINVOKE.__NumComplexFloatImage_Not(swigCPtr, __NumComplexFloatImage.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(int x, int y) {
    bool ret = VisionLabPINVOKE.__NumComplexFloatImage_CheckCoord__SWIG_0(swigCPtr, x, y);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public bool CheckCoord(XYCoord xy) {
    bool ret = VisionLabPINVOKE.__NumComplexFloatImage_CheckCoord__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetPixelPtr(int x, int y) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumComplexFloatImage_GetPixelPtr__SWIG_0(swigCPtr, x, y);
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__complexT_float_t GetPixelPtr(XYCoord xy) {
    global::System.IntPtr cPtr = VisionLabPINVOKE.__NumComplexFloatImage_GetPixelPtr__SWIG_1(swigCPtr, XYCoord.getCPtr(xy));
    SWIGTYPE_p_std__complexT_float_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__complexT_float_t(cPtr, false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public XYCoord GetXYCoord(SWIGTYPE_p_std__complexT_float_t ptr) {
    XYCoord ret = new XYCoord(VisionLabPINVOKE.__NumComplexFloatImage_GetXYCoord(swigCPtr, SWIGTYPE_p_std__complexT_float_t.getCPtr(ptr)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetPixel(int x, int y, SWIGTYPE_p_std__complexT_float_t value) {
    VisionLabPINVOKE.__NumComplexFloatImage_SetPixel(swigCPtr, x, y, SWIGTYPE_p_std__complexT_float_t.getCPtr(value));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
