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
namespace is2WakeUpDBCon.is2oshirase {
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
            this.Url = "http://localhost/is2/is2oshirase/Service1.asmx";
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Get_Message", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Get_Message(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Get_Message", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGet_Message(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Get_Message", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGet_Message(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Get_OshiraseTopN", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Get_OshiraseTopN(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Get_OshiraseTopN", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGet_OshiraseTopN(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Get_OshiraseTopN", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndGet_OshiraseTopN(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Sel_Oshirase", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Sel_Oshirase(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Sel_Oshirase", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginSel_Oshirase(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Sel_Oshirase", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndSel_Oshirase(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Ins_Oshirase", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Ins_Oshirase(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Ins_Oshirase", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginIns_Oshirase(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Ins_Oshirase", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndIns_Oshirase(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Upd_Oshirase", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Upd_Oshirase(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Upd_Oshirase", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginUpd_Oshirase(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Upd_Oshirase", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndUpd_Oshirase(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Walkthrough/XmlWebServices/Del_Oshirase", RequestNamespace="http://Walkthrough/XmlWebServices/", ResponseNamespace="http://Walkthrough/XmlWebServices/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] Del_Oshirase(string[] sUser, string[] sKey) {
            object[] results = this.Invoke("Del_Oshirase", new object[] {
                        sUser,
                        sKey});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginDel_Oshirase(string[] sUser, string[] sKey, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Del_Oshirase", new object[] {
                        sUser,
                        sKey}, callback, asyncState);
        }
        
        /// <remarks/>
        public string[] EndDel_Oshirase(System.IAsyncResult asyncResult) {
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
