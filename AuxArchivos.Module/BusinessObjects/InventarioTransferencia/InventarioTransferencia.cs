//using System;
//using System.Linq;
//using System.Text;
//using DevExpress.Xpo;
//using DevExpress.ExpressApp;
//using System.ComponentModel;
//using DevExpress.ExpressApp.DC;
//using DevExpress.Data.Filtering;
//using DevExpress.Persistent.Base;
//using System.Collections.Generic;
//using DevExpress.ExpressApp.Model;
//using DevExpress.Persistent.BaseImpl;
//using DevExpress.Persistent.Validation;

//namespace AuxArchivos.Module.BusinessObjects.InventarioTransferencia
//{
//    [DefaultClassOptions]
//    [DefaultProperty("NumeroConsecutivo")]

//    public class InventarioTransferencia : BaseObject
//    { 
//        public InventarioTransferencia(Session session)
//            : base(session)
//        {
//        }

//        private Transferencia _Transferencia;
//        [Association("Transferencia-InventarioTranferencia")]
//        public Transferencia Transferencia
//        {
//            get { return _Transferencia; }
//            set { SetPropertyValue("Transferencia", ref _Transferencia, value); }
//        }

//        private int _NumeroConsecutivo;
//        public int NumeroConsecutivo
//        {
//            get { return _NumeroConsecutivo; }
//            set { SetPropertyValue("NumeroConsecutivo", ref _NumeroConsecutivo, value); }
//        }

//        private String _NumeroClasificacion;
//        public String NumeroClasificacion
//        {
//            get { return _NumeroClasificacion; }
//            set { SetPropertyValue("_NumeroClasificacion", ref _NumeroClasificacion, value); }
//        }

//        private int _NumeroIdCaja;
//        public int NumeroIdCaja
//        {
//            get { return _NumeroIdCaja; }
//            set { SetPropertyValue("NumeroIdCaja", ref _NumeroIdCaja, value); }
//        }

//        private int _NumeroIdExpediente;
//        public int NumeroIdExpediente
//        {
//            get { return _NumeroIdExpediente; }
//            set { SetPropertyValue("NumeroIdExpediente", ref _NumeroIdExpediente, value); }
//        }

//        private String _DescripcionAsunto;
//        public String DescripcionAsunto
//        {
//            get { return _DescripcionAsunto; }
//            set { SetPropertyValue("DescripcionAsunto", ref _DescripcionAsunto, value); }
//        }

//        private DateTime _FechaApertura;
//        public DateTime FechaApertura
//        {
//            get { return _FechaApertura; }
//            set { SetPropertyValue("FechaApertura", ref _FechaApertura, value); }
//        }

//        private DateTime _FechaCierre;
//        public DateTime FechaCierre
//        {
//            get { return _FechaCierre; }
//            set { SetPropertyValue("FechaCierre", ref _FechaCierre, value); }
//        }

//        private int _NumeroFojas;
//        public int NumeroFojas
//        {
//            get { return _NumeroFojas; }
//            set { SetPropertyValue("NumeroFojas", ref _NumeroFojas, value); }
//        }

//        private Boolean _Original;
//        public Boolean Original
//        {
//            get { return _Original; }
//            set { SetPropertyValue("Original", ref _Original, value); }
//        }

//        private Boolean _Copia;
//        public Boolean Copia
//        {
//            get { return _Copia; }
//            set { SetPropertyValue("Copia", ref _Copia, value); }
//        }

//        private Boolean _Administrativo;
//        public Boolean Administrativo
//        {
//            get { return _Administrativo; }
//            set { SetPropertyValue("Administrativo", ref _Administrativo, value); }
//        }

//        private Boolean _Legal;
//        public Boolean Legal
//        {
//            get { return _Legal; }
//            set { SetPropertyValue("Legal", ref _Legal, value); }
//        }

//        private Boolean _Fiscal;
//        public Boolean Fiscal
//        {
//            get { return _Fiscal; }
//            set { SetPropertyValue("Fiscal", ref _Fiscal, value); }
//        }

//        private Boolean _Contable;
//        public Boolean Contable
//        {
//            get { return _Contable; }
//            set { SetPropertyValue("Contable", ref _Contable, value); }
//        }

//        private int _ArchivoTramite;
//        [ImmediatePostData]
//        public int ArchivoTramite
//        {
//            get { return _ArchivoTramite; }
//            set { SetPropertyValue("ArchivoTramite", ref _ArchivoTramite, value); }
//        }

//        private int _ArchivoConcentracion;
//        [ImmediatePostData]
//        public int ArchivoConcentracion
//        {
//            get { return _ArchivoConcentracion; }
//            set { SetPropertyValue("ArchivoConcentracion", ref _ArchivoConcentracion, value); }
//        }

//        [NonPersistent]

//        public int TotalDeAnios
//        {
//            get { return ArchivoConcentracion + ArchivoTramite; }
//        }

//        private Boolean _Publica;
//        public Boolean Publica
//        {
//            get { return _Publica; }
//            set { SetPropertyValue("Publica", ref _Publica, value); }
//        }

//        private Boolean _Reservada;
//        public Boolean Reservada
//        {
//            get { return _Reservada; }
//            set { SetPropertyValue("Reservada", ref _Reservada, value); }
//        }

//        private Boolean _Confidencial;
//        public Boolean Confidencial
//        {
//            get { return _Confidencial; }
//            set { SetPropertyValue("Confidencial", ref _Confidencial, value); }
//        }

//        public override void AfterConstruction()
//        {
//            base.AfterConstruction();  
//        }
//    }
//}