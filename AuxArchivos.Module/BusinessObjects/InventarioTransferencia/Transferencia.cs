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
//    [XafDisplayName("2. Formato de inventario de transferencia")]
//    [DefaultProperty("IdArchivo")]

//    public class Transferencia : BaseObject
//    { 
//        public Transferencia(Session session)
//            : base(session)
//        {
//        }

//        private int _IdArchivo;
//        public int IdArchivo
//        {
//            get { return _IdArchivo; }
//            set { SetPropertyValue("IdArchivo", ref _IdArchivo, value); }
//        }

//        private UnidadesAdministrativas _NombreUnidad;
//        public UnidadesAdministrativas NombreUnidad
//        {
//            get { return _NombreUnidad; }
//            set { SetPropertyValue("NombreUnidad", ref _NombreUnidad, value); }
//        }

//        private AreasProductoras _AreaProductora;
//        public AreasProductoras AreaProductora
//        {
//            get { return _AreaProductora; }
//            set { SetPropertyValue("AreaProductora", ref _AreaProductora, value); }
//        }

//        private Legislaturas _NumeroLegislatura;
//        public Legislaturas NumeroLegislatura
//        {
//            get { return _NumeroLegislatura; }
//            set { SetPropertyValue("NumeroLegislatura", ref _NumeroLegislatura, value); }
//        }

//        private Secciones _Seccion;
//        public Secciones Seccion
//        {
//            get { return _Seccion; }
//            set { SetPropertyValue("Seccion", ref _Seccion, value); }
//        }

//        private Series _Serie;
//        public Series Serie
//        {
//            get { return _Serie; }
//            set { SetPropertyValue("Seria", ref _Serie, value); }
//        }

//        private SubSeries _SubSerie;
//        public SubSeries SubSerie
//        {
//            get { return _SubSerie; }
//            set { SetPropertyValue("SubSeria", ref _SubSerie, value); }
//        }

//        private DateTime _FechaTransfarencia;
//        public DateTime FechaTransfarencia
//        {
//            get { return _FechaTransfarencia; }
//            set { SetPropertyValue("FechaTransfarencia", ref _FechaTransfarencia, value); }
//        }

//        private int _NoTranferencia;
//        public int NoTranferencia
//        {
//            get { return _NoTranferencia; }
//            set { SetPropertyValue("NoTranferencia", ref _NoTranferencia, value); }
//        }

//        public override void AfterConstruction()
//        {
//            base.AfterConstruction();
//        }

//        [Association("Transferencia-InventarioTranferencia")]
//        public XPCollection<InventarioTransferencia> DetallesTransferencia
//        {
//            get
//            {
//                return GetCollection<InventarioTransferencia>("DetallesTransferencia");
//            }
//        }

//    }
//}