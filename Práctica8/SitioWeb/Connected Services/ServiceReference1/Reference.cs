﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SitioWeb.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarFoto", ReplyAction="http://tempuri.org/IService1/BorrarFotoResponse")]
        void BorrarFoto(string foto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/BorrarFoto", ReplyAction="http://tempuri.org/IService1/BorrarFotoResponse")]
        System.Threading.Tasks.Task BorrarFotoAsync(string foto);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AñadirFoto", ReplyAction="http://tempuri.org/IService1/AñadirFotoResponse")]
        void AñadirFoto(string foto, string nombre, string autor, string descripcion);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/AñadirFoto", ReplyAction="http://tempuri.org/IService1/AñadirFotoResponse")]
        System.Threading.Tasks.Task AñadirFotoAsync(string foto, string nombre, string autor, string descripcion);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : SitioWeb.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<SitioWeb.ServiceReference1.IService1>, SitioWeb.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void BorrarFoto(string foto) {
            base.Channel.BorrarFoto(foto);
        }
        
        public System.Threading.Tasks.Task BorrarFotoAsync(string foto) {
            return base.Channel.BorrarFotoAsync(foto);
        }
        
        public void AñadirFoto(string foto, string nombre, string autor, string descripcion) {
            base.Channel.AñadirFoto(foto, nombre, autor, descripcion);
        }
        
        public System.Threading.Tasks.Task AñadirFotoAsync(string foto, string nombre, string autor, string descripcion) {
            return base.Channel.AñadirFotoAsync(foto, nombre, autor, descripcion);
        }
    }
}
