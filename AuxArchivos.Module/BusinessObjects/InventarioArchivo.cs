using System;
using System.Linq;
using System.Text;
using DevExpress.Xpo;
using DevExpress.ExpressApp;
using System.ComponentModel;
using DevExpress.ExpressApp.DC;
using DevExpress.Data.Filtering;
using DevExpress.Persistent.Base;
using System.Collections.Generic;
using DevExpress.ExpressApp.Model;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Persistent.Validation;
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Editors;

namespace AuxArchivos.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("NumeroConsecutivo")]

    public class InventarioArchivo : BaseObject
    { 
        public InventarioArchivo(Session session)
            : base(session)
        {
        }

        private ArchivoGeneral _ArchivoGeneral;
        [Association("Archivo-InventarioArchivo")]
        public ArchivoGeneral ArchivoGeneral
        {
            get { return _ArchivoGeneral; }
            set { SetPropertyValue("ArchivoGeneral", ref _ArchivoGeneral, value); }
        }
        //DLG: F1 o F2 o F3
        private int _NumeroConsecutivo;
        [Appearance("Pesof2", Visibility = ViewItemVisibility.Hide, 
            Criteria = "Not [ArchivoGeneral.Formato.Nombre] in ('1','2','3')", 
            Context = "Any")]
        public int NumeroConsecutivo
        {
            get { return _NumeroConsecutivo; }
            set { SetPropertyValue("NumeroConsecutivo", ref _NumeroConsecutivo, value); }
        }
        //DLG: F1 o F2 o F3
        private String _NumeroClasificacion;
        public String NumeroClasificacion
        {
            get { return _NumeroClasificacion; }
            set { SetPropertyValue("_NumeroClasificacion", ref _NumeroClasificacion, value); }
        }
        //DLG: F1 o F2 o F3
        private int _NumeroIdCaja;
        public int NumeroIdCaja
        {
            get { return _NumeroIdCaja; }
            set { SetPropertyValue("NumeroIdCaja", ref _NumeroIdCaja, value); }
        }
        //DLG: F1 o F2 o F3
        private int _NumeroIdExpediente;
        public int NumeroIdExpediente
        {
            get { return _NumeroIdExpediente; }
            set { SetPropertyValue("NumeroIdExpediente", ref _NumeroIdExpediente, value); }
        }
        //DLG: F1 o F2 o F3
        private String _DescripcionAsunto;
        public String DescripcionAsunto
        {
            get { return _DescripcionAsunto; }
            set { SetPropertyValue("DescripcionAsunto", ref _DescripcionAsunto, value); }
        }
        //DLG: F1 o F2 o F3
        private DateTime _FechaApertura;
        public DateTime FechaApertura
        {
            get { return _FechaApertura; }
            set { SetPropertyValue("FechaApertura", ref _FechaApertura, value); }
        }
        //DLG: F1 o F2 o F3
        private DateTime _FechaCierre;
        public DateTime FechaCierre
        {
            get { return _FechaCierre; }
            set { SetPropertyValue("FechaCierre", ref _FechaCierre, value); }
        }
        //DLG: F1 o F2 o F3
        private int _NumeroFojas;
        public int NumeroFojas
        {
            get { return _NumeroFojas; }
            set { SetPropertyValue("NumeroFojas", ref _NumeroFojas, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Original;
        public Boolean Original
        {
            get { return _Original; }
            set { SetPropertyValue("Original", ref _Original, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Copia;
        public Boolean Copia
        {
            get { return _Copia; }
            set { SetPropertyValue("Copia", ref _Copia, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Administrativo;
        public Boolean Administrativo
        {
            get { return _Administrativo; }
            set { SetPropertyValue("Administrativo", ref _Administrativo, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Legal;
        public Boolean Legal
        {
            get { return _Legal; }
            set { SetPropertyValue("Legal", ref _Legal, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Fiscal;
        public Boolean Fiscal
        {
            get { return _Fiscal; }
            set { SetPropertyValue("Fiscal", ref _Fiscal, value); }
        }
        //DLG: F1 o F2 o F3
        private Boolean _Contable;
        public Boolean Contable
        {
            get { return _Contable; }
            set { SetPropertyValue("Contable", ref _Contable, value); }
        }
        //DLG: F1 o F2 o F3
        private int _ArchivoTramite;
        [ImmediatePostData]
        public int ArchivoTramite
        {
            get { return _ArchivoTramite; }
            set { SetPropertyValue("ArchivoTramite", ref _ArchivoTramite, value); }
        }
        //DLG: F1 o F2 o F3
        private int _ArchivoConcentracion;
        [ImmediatePostData]
        public int ArchivoConcentracion
        {
            get { return _ArchivoConcentracion; }
            set { SetPropertyValue("ArchivoConcentracion", ref _ArchivoConcentracion, value); }
        }

        //DLG: F1 o F2 o F3
        [NonPersistent]
        public int TotalDeAnios
        {
            get { return ArchivoConcentracion+ArchivoTramite; }        
        }
        //DLG: F1 o F2 
        private Boolean _Publica;
        public Boolean Publica
        {
            get { return _Publica; }
            set { SetPropertyValue("Publica", ref _Publica, value); }
        }
        //DLG: F1 o F2 
        private Boolean _Reservada;
        public Boolean Reservada
        {
            get { return _Reservada; }
            set { SetPropertyValue("Reservada", ref _Reservada, value); }
        }
        //DLG: F1 o F2
        private Boolean _Confidencial;
        public Boolean Confidencial
        {
            get { return _Confidencial; }
            set { SetPropertyValue("Confidencial", ref _Confidencial, value); }
        }
        //DLG: F1
        private String _UbicacionTipografica;
        public String UbicacionTipografica
        {
            get { return _UbicacionTipografica; }
            set { SetPropertyValue("UbicacionTipografica", ref _UbicacionTipografica, value); }
        }
        //DLG: F4
        private int _NumeroExpedientesPorCaja;
        public int NumeroExpedientesPorCaja
        {
            get { return _NumeroExpedientesPorCaja; }
            set { SetPropertyValue("NumeroExpedientesPorCaja", ref _NumeroExpedientesPorCaja, value); }
        }
        //DLG: F4
        //DLG: Fechas Extremas
        private String _FechaExtremas;
        public String FechaExtremas
        {
            get { return _FechaExtremas; }
            set { SetPropertyValue("FechaExtremas", ref _FechaExtremas, value); }
        }
        //DLG: F4
        private String _DescripcionDocumental;
        public String DescripcionDocumental
        {
            get { return _DescripcionDocumental; }
            set { SetPropertyValue("DescripcionDocumental", ref _DescripcionDocumental, value); }
        }
        //DLG: F4
        private String _ComprovacionAdministrativa;
        public String ComprovacionAdministrativa
        {
            get { return _ComprovacionAdministrativa; }
            set { SetPropertyValue("ComprovacionAdministrativa", ref _ComprovacionAdministrativa, value); }
        }
        //DLG: F4
        private String _Observaciones;
        public String Observaciones
        {
            get { return _Observaciones; }
            set { SetPropertyValue("Observaciones", ref _Observaciones, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();   
        }  
    }
}