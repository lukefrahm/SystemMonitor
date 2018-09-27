using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemMonitor
{
    class System
    {
        public CPU[] Processors { get; private set; }
        public GPU[] VideoCards { get; private set; }
        public RAM[] PhysicalMemory { get; private set; }
        public Page[] PageFiles { get; private set; }
        public VRM[] VrmSystems { get; private set; }
        public Storage[] StorageDevices { get; private set; }
        public PSU[] PowerSupplies { get; private set; }
        public RaidCard[] RaidCards { get; private set; }
        public NIC[] NetworkCards { get; private set; }
        public Motherboard Motherboard { get; private set; }
    }

    enum Unit
    {
        Base,
        Kilo,
        Mega,
        Giga,
        Tera
    }

    class CPU
    {
        public byte CoreCount { get; set; }
        public byte Temp_Max { get; set; }
        public float VCore_Max { get; set; }
        public float VCCIO_Max { get; set; }
        public float VCCSA_Max { get; set; }
    }

    class GPU
    {
        public byte Temp_Max { get; set; }
        public float VCore_Max { get; set; }
        public float VMem_Max { get; set; }
        public ulong Mem_Cap { get; set; }
    }

    class RAM
    {
        public ulong Mem_Cap { get; set; }
        public ulong[] MemCapPerDIMM { get; set; }
        public byte DIMM_Count { get; set; }
        public float VTT_Max { get; set; }
    }

    class VRM
    {
        public ushort Amps_Max { get; set; }
        public float Temp_Max { get; set; }
    }

    class Storage
    {
        public ulong ByteCapacity { get; set; }
        public float Temp_Max { get; set; }
        public float SMART_Status { get; set; }
    }

    class PSU
    {
        public ushort Watts_Max { get; set; }
        public float Temp_Max { get; set; }
    }

    class RaidCard
    {
        public byte DriveCount_Max { get; set; }
        public float Temp_Max { get; set; }
    }

    class NIC
    {
        public byte PortCount { get; set; }
        public Unit PortSpeed_Max { get; set; }
        public float Temp_Max { get; set; }
        public bool WOL_Active { get; set; }
        public bool IsTeamed { get; set; }
        public bool IsCritical { get; set; }
    }

    class Motherboard
    {
        public float BCLK_Low { get; set; }
        public float BCLK_High { get; set; }
        public TempSensor[] TempSensors { get; set; }
        public Fan[] Fans { get; set; }
    }

    class Page
    {
        public ulong ByteCapacity { get; set; }
        public byte PercentUsed { get; set; }
    }

    class Fan
    {
        public byte SpeedPercent { get; set; }
        public bool IsFunctioning { get; set; }
    }

    class TempSensor
    {
        public int Location { get; set; }
        public byte Temp_Max { get; set; }
    }
}
