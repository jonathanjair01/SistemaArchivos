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
    [DefaultProperty("Legislatura")]

    public class Legislaturas : BaseObject
    { 
        public Legislaturas(Session session)
            : base(session)
        {
        }

        private String _Legislatura;
        public String Legislatura
        {
            get { return _Legislatura; }
            set { SetPropertyValue("Legislatura", ref _Legislatura, value); }
        }

        public override void AfterConstruction()
        {
            base.AfterConstruction();  
        }
    }
}