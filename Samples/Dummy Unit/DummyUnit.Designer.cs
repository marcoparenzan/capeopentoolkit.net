﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:2.0.50727.42
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapeOpenDummy {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Mose.CapeOpenToolkit.UnitProxy;
    using System.Runtime.InteropServices;
    
    
    [System.Runtime.InteropServices.GuidAttribute("43d9f0a5-36b6-4d27-b838-ec6016311cb1")]
    public partial class DummyUnit {
        
        public DummyUnit() : 
                base() {
        }
        
        public Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject InputPort {
            get {
                Mose.CapeOpenToolkit.UnitProxy.MaterialPort zPort;
                zPort = ((Mose.CapeOpenToolkit.UnitProxy.MaterialPort)(Ports.GetPortByName("InputPort")));
                return ((Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject)(zPort.ConnectedObject));
            }
        }
        
        public Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject OutputPort {
            get {
                Mose.CapeOpenToolkit.UnitProxy.MaterialPort zPort;
                zPort = ((Mose.CapeOpenToolkit.UnitProxy.MaterialPort)(Ports.GetPortByName("OutputPort")));
                return ((Mose.CapeOpenToolkit.UnitProxy.CapeOpenThermoMaterialObject)(zPort.ConnectedObject));
            }
        }
        
        protected override void OnInitialize() {
            Name = "DummyUnit";
            Description = "Unit Dummy .NET";
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "InputPort", "Input Port of Dummy", CapeOpenPortDirection.Inlet));
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "OutputPort", "Output Port of Dummy", CapeOpenPortDirection.Outlet));
        }
    }
}
