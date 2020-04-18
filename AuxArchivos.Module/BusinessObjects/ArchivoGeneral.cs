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
using DevExpress.ExpressApp.ConditionalAppearance;
using DevExpress.ExpressApp.Editors;

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
        [ImmediatePostData]
        [XafDisplayName("Tipo de Formato a realizar"), ToolTip("Selecciona un formato a realizar")]
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

        //DLG: F1 o F2 o F4
        private UnidadesAdministrativas _NombreUnidad;
        [XafDisplayName("Unidad Administrativa")]
        public UnidadesAdministrativas NombreUnidad
        {
            get { return _NombreUnidad; }
            set { SetPropertyValue("NombreUnidad", ref _NombreUnidad, value); }
        }
        //DLG: F1 o F2 o F4
        private AreasProductoras _AreaProductora;
        [XafDisplayName("Área Productora")]
        public AreasProductoras AreaProductora
        {
            get { return _AreaProductora; }
            set { SetPropertyValue("AreaProductora", ref _AreaProductora, value); }
        }
        //DLG: F1 o F2 o F4
        private Legislaturas _NumeroLegislatura;
        [XafDisplayName("No. de Legislatura")]
        public Legislaturas NumeroLegislatura
        {
            get { return _NumeroLegislatura; }
            set { SetPropertyValue("NumeroLegislatura", ref _NumeroLegislatura, value); }
        }
        //DLG: F1 o F2
        private Secciones _Seccion;
        [XafDisplayName("Sección")]
        public Secciones Seccion
        {
            get { return _Seccion; }
            set { SetPropertyValue("Seccion", ref _Seccion, value); }
        }
        //DLG: F1 o F2
        private Series _Serie;
        [XafDisplayName("Serie")]
        public Series Serie
        {
            get { return _Serie; }
            set { SetPropertyValue("Seria", ref _Serie, value); }
        }
        //DLG: F1 o F2
        private SubSeries _SubSerie;
        [XafDisplayName("Subserie")]
        public SubSeries SubSerie
        {
            get { return _SubSerie; }
            set { SetPropertyValue("SubSeria", ref _SubSerie, value); }
        }
        //DLG: F1 o F4
        private DateTime _FechaEmision;
        [XafDisplayName("Fecha de Emisión")]
        [Appearance("FechaEmision", Visibility = ViewItemVisibility.Hide, Criteria = "Not [Formato.Nombre] in ('1')", Context = "DetailView")]
        public DateTime FechaEmision
        {
            get { return _FechaEmision; }
            set { SetPropertyValue("FechaEmision", ref _FechaEmision, value); }
        }

        //DLG: F2
        private DateTime _FechaTranferencia;
        [XafDisplayName("Fecha de transferencia")]
        [Appearance("FechaTransF2", Visibility = ViewItemVisibility.Hide, Criteria = "Not [Formato.Nombre] in ('2')", Context = "DetailView")]
        public DateTime FechaTranferencia
        {
            get { return _FechaTranferencia; }
            set { SetPropertyValue("FechaTranferencia", ref _FechaTranferencia, value); }
        }

        //DLG: F2
        private int _NoTranferencia;
        [XafDisplayName("No. de transferencia")]
        [Appearance("NoTranferenciaF2", Visibility = ViewItemVisibility.Hide, Criteria = "Not [Formato.Nombre] in ('2')", Context = "DetailView")]
        public int NoTranferencia
        {
            get { return _NoTranferencia; }
            set { SetPropertyValue("NoTranferencia", ref _NoTranferencia, value); }
        }

        //DLG: F2 o F4
        private int _NoPaginas;
        [XafDisplayName("No. de página(s)")]
        [Appearance("PaginasF2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public int NoPaginas
        {
            get { return _NoPaginas; }
            set { SetPropertyValue("NoPaginas", ref _NoPaginas, value); }
        }

        //DLG: F2 o F4
        private int _NoExpedientes;
        [XafDisplayName("Cantidad de expedientes")]
        [Appearance("NoExpF2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public int NoExpedientes
        {
            get { return _NoExpedientes; }
            set { SetPropertyValue("NoExpedientes", ref _NoExpedientes, value); }
        }

        //DLG: F2 o F4
        private DateTime _AnioA;
        [XafDisplayName("Año inicial")]
        [Appearance("AniF2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public DateTime AnioA
        {
            get { return _AnioA; }
            set { SetPropertyValue("AnioA", ref _AnioA, value); }
        }

        //DLG: F2 o F4
        private DateTime _AnioB;
        [XafDisplayName("Año final")]
        [Appearance("Aniobf2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public DateTime AnioB
        {
            get { return _AnioB; }
            set { SetPropertyValue("AnioB", ref _AnioB, value); }
        }

        //DLG: F2 o F4
        private int _NoCajas;
        [XafDisplayName("Cantidad de cajas")]
        [Appearance("NoCajasF2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public int NoCajas
        {
            get { return _NoCajas; }
            set { SetPropertyValue("NoCajas", ref _NoCajas, value); }
        }

        //DLG: F2 o F4
        private int _Peso;
        [XafDisplayName("Peso aproximado en kilogramos")]
        [Appearance("Pesof2", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public int Peso
        {
            get { return _Peso; }
            set { SetPropertyValue("Peso", ref _Peso, value); }
        }

        //DLG: Elaboro
        //DLG: F2 o F4
        private String _NombreElaboro;
        [XafDisplayName("Nombre de Quién Elaboró")]
        [Appearance("20", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String NombreElaboro
        {
            get { return _NombreElaboro; }
            set { SetPropertyValue("NombreElaboro", ref _NombreElaboro, value); }
        }

        //DLG: F2 o F4
        private String _CargoyAreaElaboro;
        [XafDisplayName("Cargo y área")]
        [Appearance("25", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String CargoyAreaElaboro
        {
            get { return _CargoyAreaElaboro; }
            set { SetPropertyValue("CargoyAreaElaboro", ref _CargoyAreaElaboro, value); }
        }

        //DLG: Reviso
        //DLG: F2 o F4
        private String _NombreReviso;
        [XafDisplayName("Nombre de Quién Revisó")]
        [Appearance("29", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String NombreReviso
        {
            get { return _NombreReviso; }
            set { SetPropertyValue("NombreReviso", ref _NombreReviso, value); }
        }

        //DLG: F2 o F4
        private String _CargoyAreaReviso;
        [XafDisplayName("Cargo y área")]
        [Appearance("30", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String CargoyAreaReviso
        {
            get { return _CargoyAreaReviso; }
            set { SetPropertyValue("CargoyAreaReviso", ref _CargoyAreaReviso, value); }
        }

        //DLG: Autorizo
        //DLG: F2 o F4
        private String _NombreAutorizo;
        [XafDisplayName("Nombre de Quién Autorizó")]
        [Appearance("31", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String NombreAutorizo
        {
            get { return _NombreAutorizo; }
            set { SetPropertyValue("NombreAutorizo", ref _NombreAutorizo, value); }
        }

        //DLG: F2 o F4
        private String _CargoyAreaAutorizo;
        [XafDisplayName("Cargo y área")]
        [Appearance("32", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String CargoyAreaAutorizo
        {
            get { return _CargoyAreaAutorizo; }
            set { SetPropertyValue("CargoyAreaAutorizo", ref _CargoyAreaAutorizo, value); }
        }

        //DLG: Valido
        //DLG: F2
        private String _NombreValido;
        [XafDisplayName("Nombre de Quién Validó")]
        [Appearance("33", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String NombreValido
        {
            get { return _NombreValido; }
            set { SetPropertyValue("NombreValido", ref _NombreValido, value); }
        }

        //DLG: F2
        private String _CargoyAreaValido;
        [XafDisplayName("Cargo y área")]
        [Appearance("35", Visibility = ViewItemVisibility.Hide, Criteria = "[Formato.Nombre] != '2'", Context = "DetailView")]
        public String CargoyAreaValido
        {
            get { return _CargoyAreaValido; }
            set { SetPropertyValue("CargoyAreaValido", ref _CargoyAreaValido, value); }
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