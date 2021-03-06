/* ----------------------------------------------------------------------------
 * This file was automatically generated by SWIG (http://www.swig.org).
 * Version 2.0.9
 *
 * Do not make changes to this file unless you know what you are doing--modify
 * the SWIG interface file instead.
 * ----------------------------------------------------------------------------- */

namespace org.doubango.tinyWRAP {

using System;
using System.Runtime.InteropServices;

public class ProxyPluginMgr : IDisposable {
  private HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal ProxyPluginMgr(IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new HandleRef(this, cPtr);
  }

  internal static HandleRef getCPtr(ProxyPluginMgr obj) {
    return (obj == null) ? new HandleRef(null, IntPtr.Zero) : obj.swigCPtr;
  }

  ~ProxyPluginMgr() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          tinyWRAPPINVOKE.delete_ProxyPluginMgr(swigCPtr);
        }
        swigCPtr = new HandleRef(null, IntPtr.Zero);
      }
      GC.SuppressFinalize(this);
    }
  }

  public static ProxyPluginMgr createInstance(ProxyPluginMgrCallback pCallback) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_createInstance(ProxyPluginMgrCallback.getCPtr(pCallback));
    ProxyPluginMgr ret = (cPtr == IntPtr.Zero) ? null : new ProxyPluginMgr(cPtr, true);
    return ret;
  }

  public static ProxyPluginMgr getInstance() {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_getInstance();
    ProxyPluginMgr ret = (cPtr == IntPtr.Zero) ? null : new ProxyPluginMgr(cPtr, false);
    return ret;
  }

  public ProxyPlugin findPlugin(ulong id) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_findPlugin(swigCPtr, id);
    ProxyPlugin ret = (cPtr == IntPtr.Zero) ? null : new ProxyPlugin(cPtr, false);
    return ret;
  }

  public ProxyAudioConsumer findAudioConsumer(ulong id) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_findAudioConsumer(swigCPtr, id);
    ProxyAudioConsumer ret = (cPtr == IntPtr.Zero) ? null : new ProxyAudioConsumer(cPtr, false);
    return ret;
  }

  public ProxyVideoConsumer findVideoConsumer(ulong id) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_findVideoConsumer(swigCPtr, id);
    ProxyVideoConsumer ret = (cPtr == IntPtr.Zero) ? null : new ProxyVideoConsumer(cPtr, false);
    return ret;
  }

  public ProxyAudioProducer findAudioProducer(ulong id) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_findAudioProducer(swigCPtr, id);
    ProxyAudioProducer ret = (cPtr == IntPtr.Zero) ? null : new ProxyAudioProducer(cPtr, false);
    return ret;
  }

  public ProxyVideoProducer findVideoProducer(ulong id) {
    IntPtr cPtr = tinyWRAPPINVOKE.ProxyPluginMgr_findVideoProducer(swigCPtr, id);
    ProxyVideoProducer ret = (cPtr == IntPtr.Zero) ? null : new ProxyVideoProducer(cPtr, false);
    return ret;
  }

}

}
