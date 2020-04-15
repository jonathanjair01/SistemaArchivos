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
    [DefaultProperty("NombreAreaProductora")]

    public class AreasProductoras : BaseObject
    { 
        public AreasProductoras(Session session)
            : base(session)
        {
        }

        private String _NombreAreaProductora;
        public String NombreAreaProductora
        {
            get { return _NombreAreaProductora; }
            set { SetPropertyValue("NombreAreaProductora", ref _NombreAreaProductora, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();
        } 
    }
}