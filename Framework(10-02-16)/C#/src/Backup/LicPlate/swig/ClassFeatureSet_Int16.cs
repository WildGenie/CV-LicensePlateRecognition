/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 3.0.2
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */


public class ClassFeatureSet_Int16 : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ClassFeatureSet_Int16(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(ClassFeatureSet_Int16 obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~ClassFeatureSet_Int16() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          VisionLabPINVOKE.delete_ClassFeatureSet_Int16(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public ClassFeatureSet_Int16() : this(VisionLabPINVOKE.new_ClassFeatureSet_Int16__SWIG_0(), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public ClassFeatureSet_Int16(string info) : this(VisionLabPINVOKE.new_ClassFeatureSet_Int16__SWIG_1(info), true) {
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public virtual string GetImageType() {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Int16_GetImageType(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int AddClass(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_AddClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int ClassId(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_ClassId(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string ClassName(int classId) {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Int16_ClassName(swigCPtr, classId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t GetClassTab() {
    SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(VisionLabPINVOKE.ClassFeatureSet_Int16_GetClassTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int MaxClassId() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_MaxClassId(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveClass(string className) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_RemoveClass(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddImage(string className, Int16Image image) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_AddImage(swigCPtr, className, Int16Image.getCPtr(image));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public Int16Image GetImage(string className, int imageIndex) {
    Int16Image ret = new Int16Image(VisionLabPINVOKE.ClassFeatureSet_Int16_GetImage(swigCPtr, className, imageIndex), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetClassIds(vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_GetClassIds(swigCPtr, vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int NrOfImages(string className) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_NrOfImages(swigCPtr, className);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveImage(string className, int imageIndex) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_RemoveImage(swigCPtr, className, imageIndex);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int AddFeature(string featureName) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_AddFeature(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int FeatureId(string featureName) {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_FeatureId(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public string FeatureName(int featureId) {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Int16_FeatureName(swigCPtr, featureId);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t GetFeatureNameTab() {
    SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(VisionLabPINVOKE.ClassFeatureSet_Int16_GetFeatureNameTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void RemoveFeature(string featureName) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_RemoveFeature(swigCPtr, featureName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public int GetNrFeatures() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_GetNrFeatures(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_double GetFeaturesImage(string className, int imageIndex) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Int16_GetFeaturesImage(swigCPtr, className, imageIndex), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetFeaturesImage(string className, int imageIndex, vector_double f) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_SetFeaturesImage(swigCPtr, className, imageIndex, vector_double.getCPtr(f));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void GetSet(vector_vector_double features, vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_GetSet(swigCPtr, vector_vector_double.getCPtr(features), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public bool SelectFeature(string featureName, bool selected) {
    bool ret = VisionLabPINVOKE.ClassFeatureSet_Int16_SelectFeature(swigCPtr, featureName, selected);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public int GetNrSelectedFeatures() {
    int ret = VisionLabPINVOKE.ClassFeatureSet_Int16_GetNrSelectedFeatures(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_bool GetSelectTab() {
    vector_bool ret = new vector_bool(VisionLabPINVOKE.ClassFeatureSet_Int16_GetSelectTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetSelectTab(vector_bool tab) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_SetSelectTab(swigCPtr, vector_bool.getCPtr(tab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_double GetSelectedFeaturesImage(string className, int imageIndex) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Int16_GetSelectedFeaturesImage(swigCPtr, className, imageIndex), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void GetSelectedSet(vector_vector_double features, vector_int classIds) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_GetSelectedSet(swigCPtr, vector_vector_double.getCPtr(features), vector_int.getCPtr(classIds));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public vector_double GetSelectedFeatures(vector_double features) {
    vector_double ret = new vector_double(VisionLabPINVOKE.ClassFeatureSet_Int16_GetSelectedFeatures(swigCPtr, vector_double.getCPtr(features)), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_MinMaxInput GetMinMaxTab() {
    vector_MinMaxInput ret = new vector_MinMaxInput(VisionLabPINVOKE.ClassFeatureSet_Int16_GetMinMaxTab(swigCPtr), false);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public vector_MinMaxInput GetSelectedMinMaxTab() {
    vector_MinMaxInput ret = new vector_MinMaxInput(VisionLabPINVOKE.ClassFeatureSet_Int16_GetSelectedMinMaxTab(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetMinMaxTab(vector_MinMaxInput minMaxTab) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_SetMinMaxTab(swigCPtr, vector_MinMaxInput.getCPtr(minMaxTab));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void CalcMinMaxTab() {
    VisionLabPINVOKE.ClassFeatureSet_Int16_CalcMinMaxTab(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ResetMinMaxTab() {
    VisionLabPINVOKE.ClassFeatureSet_Int16_ResetMinMaxTab(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public string GetInfo() {
    string ret = VisionLabPINVOKE.ClassFeatureSet_Int16_GetInfo(swigCPtr);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void SetScriptName(SWIGTYPE_p_QString name) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_SetScriptName(swigCPtr, SWIGTYPE_p_QString.getCPtr(name));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString GetScriptName() {
    SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Int16_GetScriptName(swigCPtr), true);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    return ret;
  }

  public void WriteToFile(string fileName) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_WriteToFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromFile(string fileName) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_ReadFromFile(swigCPtr, fileName);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void WriteToStream(SWIGTYPE_p_std__ostream os) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_WriteToStream(swigCPtr, SWIGTYPE_p_std__ostream.getCPtr(os));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public void ReadFromStream(SWIGTYPE_p_std__istream arg0) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_ReadFromStream(swigCPtr, SWIGTYPE_p_std__istream.getCPtr(arg0));
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

  public SWIGTYPE_p_QString info {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_info_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Int16_info_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_QString scriptName {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_scriptName_set(swigCPtr, SWIGTYPE_p_QString.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      SWIGTYPE_p_QString ret = new SWIGTYPE_p_QString(VisionLabPINVOKE.ClassFeatureSet_Int16_scriptName_get(swigCPtr), true);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t classTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_classTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_classTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t featureNameTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_featureNameTab_set(swigCPtr, SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_featureNameTab_get(swigCPtr);
      SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t ret = (cPtr == global::System.IntPtr.Zero) ? null : new SWIGTYPE_p_std__mapT_std__string_int_std__lessT_std__string_t_t(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_Int16Image imageTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_imageTab_set(swigCPtr, vector_vector_Int16Image.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_imageTab_get(swigCPtr);
      vector_vector_Int16Image ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_vector_Int16Image(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_vector_vector_double featureTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_featureTab_set(swigCPtr, vector_vector_vector_double.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_featureTab_get(swigCPtr);
      vector_vector_vector_double ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_vector_vector_double(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_bool selectTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_selectTab_set(swigCPtr, vector_bool.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_selectTab_get(swigCPtr);
      vector_bool ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_bool(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public vector_MinMaxInput minMaxTab {
    set {
      VisionLabPINVOKE.ClassFeatureSet_Int16_minMaxTab_set(swigCPtr, vector_MinMaxInput.getCPtr(value));
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
    } 
    get {
      global::System.IntPtr cPtr = VisionLabPINVOKE.ClassFeatureSet_Int16_minMaxTab_get(swigCPtr);
      vector_MinMaxInput ret = (cPtr == global::System.IntPtr.Zero) ? null : new vector_MinMaxInput(cPtr, false);
      if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
      return ret;
    } 
  }

  public void Init(string info) {
    VisionLabPINVOKE.ClassFeatureSet_Int16_Init(swigCPtr, info);
    if (VisionLabPINVOKE.SWIGPendingException.Pending) throw VisionLabPINVOKE.SWIGPendingException.Retrieve();
  }

}
