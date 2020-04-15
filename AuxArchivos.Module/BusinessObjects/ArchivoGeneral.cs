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
using AuxArchivos.Module.BusinessObjects.InventarioTransferencia;

namespace AuxArchivos.Module.BusinessObjects
{
    [DefaultClassOptions]
    [XafDisplayName("Formatos")]
    [DefaultProperty("IdArchivo")]

    public class ArchivoGeneral : BaseObject
    {
        public ArchivoGeneral(Session session)
            : base(session)
        {
        }

        //DLG: Propiedad para seleccionar el formato o accion a realizar, permite el filtrado de propiedades de acuerdo al trámite
        private FormatosDeArchivo formato;
        [XafDisplayName("Acción / Formato a realizar"), ToolTip("My hint message")]
        //[ModelDefault("EditMask", "(000)-00"), Index(0), VisibleInListView(false)]
        //[Persistent("DatabaseColumnName"), RuleRequiredField(DefaultContexts.Save)]
        public FormatosDeArchivo Formato
        {
            get { return formato; }
            set { SetPropertyValue("Formato", ref formato, value); }
        }

        //DLG: Folio para guardar o buscar
        private int _IdArchivo;
        [XafDisplayName("Folio"), ToolTip("Folio del sistema para recuperar trámite o realizar uno nuevo con el mismo contenido")]
        public int IdArchivo
        {
            get { return _IdArchivo; }
            set { SetPropertyValue("IdArchivo", ref _IdArchivo, value); }
        }

        //DLG: F1
        private UnidadesAdministrativas _NombreUnidad;
        public UnidadesAdministrativas NombreUnidad
        {
            get { return _NombreUnidad; }
            set { SetPropertyValue("NombreUnidad", ref _NombreUnidad, value); }
        }
        //DLG: F1
        private AreasProductoras _AreaProductora;
        public AreasProductoras AreaProductora
        {
            get { return _AreaProductora; }
            set { SetPropertyValue("AreaProductora", ref _AreaProductora, value); }
        }
        //DLG: F1
        private Legislaturas _NumeroLegislatura;
        public Legislaturas NumeroLegislatura
        {
            get { return _NumeroLegislatura; }
            set { SetPropertyValue("NumeroLegislatura", ref _NumeroLegislatura, value); }
        }
        //DLG: F1
        private Secciones _Seccion;
        public Secciones Seccion
        {
            get { return _Seccion; }
            set { SetPropertyValue("Seccion", ref _Seccion, value); }
        }
        //DLG: F1
        private Series _Serie;
        public Series Serie
        {
            get { return _Serie; }
            set { SetPropertyValue("Seria", ref _Serie, value); }
        }
        //DLG: F1
        private SubSeries _SubSerie;
        public SubSeries SubSerie
        {
            get { return _SubSerie; }
            set { SetPropertyValue("SubSeria", ref _SubSerie, value); }
        }
        //DLG: F1
        private DateTime _FechaEmision;
        public DateTime FechaEmision
        {
            get { return _FechaEmision; }
            set { SetPropertyValue("FechaEmision", ref _FechaEmision, value); }
        }

        //DLG: F2
        private DateTime _FechaTranferencia;
        public DateTime FechaTranferencia
        {
            get { return _FechaTranferencia; }
            set { SetPropertyValue("FechaTranferencia", ref _FechaTranferencia, value); }
        }

        //DLG: F2
        private int _NoTranferencia;
        public int NoTranferencia
        {
            get { return _NoTranferencia; }
            set { SetPropertyValue("NoTranferencia", ref _NoTranferencia, value); }
        }

        //DLG: F2
        private int _NoPaginas;
        public int NoPaginas
        {
            get { return _NoPaginas; }
            set { SetPropertyValue("NoPaginas", ref _NoPaginas, value); }
        }

        //DLG: F2
        private int _NoExpedientes;
        public int NoExpedientes
        {
            get { return _NoExpedientes; }
            set { SetPropertyValue("NoExpedientes", ref _NoExpedientes, value); }
        }

        //DLG: F2
        private DateTime _AnioA;
        public DateTime AnioA
        {
            get { return _AnioA; }
            set { SetPropertyValue("AnioA", ref _AnioA, value); }
        }

        //DLG: F2
        private DateTime _AnioB;
        public DateTime AnioB
        {
            get { return _AnioB; }
            set { SetPropertyValue("AnioB", ref _AnioB, value); }
        }

        //DLG: F2
        private int _NoCajas;
        public int NoCajas
        {
            get { return _NoCajas; }
            set { SetPropertyValue("NoCajas", ref _NoCajas, value); }
        }

        //DLG: F2
        private int _Peso;
        public int Peso
        {
            get { return _Peso; }
            set { SetPropertyValue("Peso", ref _Peso, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }

        [Association("Archivo-InventarioArchivo")]
        public XPCollection<InventarioArchivo> DetallesArchivo
        {
            get
            {
                return GetCollection<InventarioArchivo>("DetallesArchivo");
            }
        }

    }
}