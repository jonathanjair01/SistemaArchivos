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

namespace AuxArchivos.Module.BusinessObjects
{
    [DefaultClassOptions]
    [DefaultProperty("NombreUnidad")]

    public class UnidadesAdministrativas : BaseObject
    { 
        public UnidadesAdministrativas(Session session)
            : base(session)
        {
        }

        private String _NombreUnidad;
        public String NombreUnidad
        {
            get { return _NombreUnidad; }
            set { SetPropertyValue("NombreUnidad", ref _NombreUnidad, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }
    }
}