﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Il codice è stato generato da uno strumento.
//     Versione runtime:2.0.50727.42
//
//     Le modifiche apportate a questo file possono provocare un comportamento non corretto e andranno perse se
//     il codice viene rigenerato.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CapeOpenWar {
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Mose.CapeOpenToolkit.UnitProxy;
    using System.Runtime.InteropServices;
    
    
    [System.Runtime.InteropServices.GuidAttribute("841dc8ea-497d-4edb-b46a-b757e63f12d6")]
    public partial class WarUnit {
        
        public WarUnit() : 
                base() {
        }
        
        public double ProcessTypeValue {
            get {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("ProcessType")));
                return zParam.Value;
            }
            set {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("ProcessType")));
                zParam.Value = value;
            }
        }
        
        public double CapePositionValue {
            get {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("CapePosition")));
                return zParam.Value;
            }
            set {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("CapePosition")));
                zParam.Value = value;
            }
        }
        
        public double CapeIDValue {
            get {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("CapeID")));
                return zParam.Value;
            }
            set {
                Mose.CapeOpenToolkit.UnitProxy.DoubleParameter zParam;
                zParam = ((Mose.CapeOpenToolkit.UnitProxy.DoubleParameter)(Parameters.GetParameterByName("CapeID")));
                zParam.Value = value;
            }
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
            Name = "WarUnit";
            Description = "War Unit .Net";
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "InputPort", "Inpot Port of War", CapeOpenPortDirection.Inlet));
            Ports.Add(CapeOpenUnitPort.Create(CapeOpenPortType.Material, "OutputPort", "Output Port of War", CapeOpenPortDirection.Outlet));
            Parameters.Add(DoubleParameter.Create("ProcessType", "CP or EP", CapeOpenParameterMode.ReadWrite, -1E+35, 1E+35, 0));
            Parameters.Add(DoubleParameter.Create("CapePosition", "Position of CO", CapeOpenParameterMode.ReadWrite, -1E+35, 1E+35, 0));
            Parameters.Add(DoubleParameter.Create("CapeID", "Name of CO", CapeOpenParameterMode.ReadWrite, -1E+35, 1E+35, 0));
        }
    }
}
