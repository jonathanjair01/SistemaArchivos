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
    [DefaultProperty("NombreSeries")]

    public class Series : BaseObject
    { 
        public Series(Session session)
            : base(session)
        {
        }

        private String _NombreSeries;
        public String NombreSeries
        {
            get { return _NombreSeries; }
            set { SetPropertyValue("NombreSeries", ref _NombreSeries, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        }  
    }
}