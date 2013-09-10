//
// DO NOT MODIFY! THIS IS AUTOGENERATED FILE!
//
namespace Xilium.CefGlue
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.Runtime.InteropServices;
    using Xilium.CefGlue.Interop;
    
    // Role: PROXY
    public sealed unsafe partial class CefXmlReader : IDisposable
    {
        internal static CefXmlReader FromNative(cef_xml_reader_t* ptr)
        {
            return new CefXmlReader(ptr);
        }
        
        internal static CefXmlReader FromNativeOrNull(cef_xml_reader_t* ptr)
        {
            if (ptr == null) return null;
            return new CefXmlReader(ptr);
        }
        
        private cef_xml_reader_t* _self;
        
        private CefXmlReader(cef_xml_reader_t* ptr)
        {
            if (ptr == null) throw new ArgumentNullException("ptr");
            _self = ptr;
        }
        
        ~CefXmlReader()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
        }
        
        public void Dispose()
        {
            if (_self != null)
            {
                Release();
                _self = null;
            }
            GC.SuppressFinalize(this);
        }
        
        internal int AddRef()
        {
            return cef_xml_reader_t.add_ref(_self);
        }
        
        internal int Release()
        {
            return cef_xml_reader_t.release(_self);
        }
        
        internal int RefCt
        {
            get { return cef_xml_reader_t.get_refct(_self); }
        }
        
        internal cef_xml_reader_t* ToNative()
        {
            AddRef();
            return _self;
        }
    }
}
