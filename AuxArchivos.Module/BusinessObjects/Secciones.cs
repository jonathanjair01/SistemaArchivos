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
    [DefaultProperty("NombreSeccion")]   

    public class Secciones : BaseObject
    { 
        public Secciones(Session session)
            : base(session)
        {
        }

        private String _NombreSeccion;
        public String NombreSeccion
        {
            get { return _NombreSeccion; }
            set { SetPropertyValue("NombreSeccion", ref _NombreSeccion, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();   
        } 
    }
}