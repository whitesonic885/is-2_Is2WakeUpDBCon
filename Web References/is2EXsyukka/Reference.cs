﻿//------------------------------------------------------------------------------
// <autogenerated>
//     This code was generated by a tool.
//     Runtime Version: 1.1.4322.2443
//
//     Changes to this file may cause incorrect behavior and will be lost if 
//     the code is regenerated.
// </autogenerated>
//------------------------------------------------------------------------------

// 
// このソース コードは Microsoft.VSDesigner、バージョン 1.1.4322.2443 によって自動生成されました。
// 
namespace is2WakeUpDBCon.is2EXsyukka {
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System;
    using System.Web.Services.Protocols;
    using System.ComponentModel;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="Service1Soap", Namespace="http://Walkthrough/XmlWebServices/")]
    public class Service1 : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        /// <remarks/>
        public Service1() {
            this.Url = "http://localhost/is2ex/is2EXsyukka/Service1.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Ins_EX_syukka", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Ins_EX_syukka(string[] sUser, string[] sData) {
            object[] results = this.Invoke("Ins_EX_syukka", new object[] {
                        sUser,
                        sData});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIns_EX_syukka(string[] sUser, string[] sData, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ins_EX_syukka", new object[] {
                        sUser,
                        sData}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndIns_EX_syukka(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Get_St01Status", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Get_St01Status(string[] sUser, string[] sKaiinCD, string sUpdDateTime) {
            object[] results = this.Invoke("Get_St01Status", new object[] {
                        sUser,
                        sKaiinCD,
                        sUpdDateTime});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGet_St01Status(string[] sUser, string[] sKaiinCD, string sUpdDateTime, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Get_St01Status", new object[] {
                        sUser,
                        sKaiinCD,
                        sUpdDateTime}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGet_St01Status(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/wakeupDB", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string wakeupDB() {
            object[] results = this.Invoke("wakeupDB", new object[0]);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginwakeupDB(System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("wakeupDB", new object[0], callback, asyncState);
        }
        
        /// <remarks/>
        public string EndwakeupDB(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/wakeupDB2", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string wakeupDB2(int iConCnt) {
            object[] results = this.Invoke("wakeupDB2", new object[] {
                        iConCnt});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginwakeupDB2(int iConCnt, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("wakeupDB2", new object[] {
                        iConCnt}, callback, asyncState);
        }
        
        /// <remarks/>
        public string EndwakeupDB2(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string)(results[0]));
        }
    }
}