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
    [DefaultProperty("NombreSubSeries")]

    public class SubSeries : BaseObject
    { 
        public SubSeries(Session session)
            : base(session)
        {
        }

        private String _NombreSubSeries;
        public String NombreSubSeries
        {
            get { return _NombreSubSeries; }
            set { SetPropertyValue("NombreSubSeries", ref _NombreSubSeries, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();    
        }   
    }
}