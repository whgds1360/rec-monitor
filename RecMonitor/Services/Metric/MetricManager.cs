using LibreHardwareMonitor.Hardware;
using Services.Metric.UpdateVisitor;

namespace RecMonitor.Services.Metric
{
    internal class MetricManager
    {
        private Computer? computer;

        public MetricManager()
        {
            try
            {
                this.computer = new Computer
                {
                    IsCpuEnabled = true,
                    IsGpuEnabled = true,
                    IsMemoryEnabled = true,
                };
            }
            catch (Exception error)
            {
                MessageBox.Show($"Ошибка инициализации сборщика метриков: {error.Message}");
            }
        }

        public Dictionary<string, Dictionary<string, float?>>? GetMetricInfo()
        {
            try
            {
                if (this.computer is null)
                {
                    throw new ArgumentNullException("Ошибка инициализации сборщика метриков");
                }

                this.computer.Open();
                this.computer.Accept(new UpdateVisitor());

                var cpuData = GetCPUInfo(this.computer);
                var gpuData = GetGPUInfo(this.computer);
                var ramData = GetRAMInfo(this.computer);

                return new Dictionary<string, Dictionary<string, float?>>
                {
                    ["CPU"] = cpuData,
                    ["GPU"] = gpuData,
                    ["RAM"] = ramData
                };
            }

            catch (Exception error)
            {
                MessageBox.Show($"Ошибка: {error.Message}");
                return null;
            }
        }

        private static Dictionary<string, float?> GetCPUInfo(Computer computer)
        {
            Dictionary<string, float?> CPUData = new Dictionary<string, float?>();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.Cpu)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        switch (sensor.SensorType)
                        {
                            case SensorType.Load:
                                {
                                    CPUData["Load"] = sensor.Value;
                                    break;
                                }
                            case SensorType.Temperature:
                                {
                                    CPUData["Temp"] = sensor.Value;
                                    break;
                                }
                            case SensorType.Frequency:
                                {
                                    CPUData["Freq"] = sensor.Value;
                                    break;
                                }
                        }
                    }
                }
            }

            return CPUData;
        }

        private static Dictionary<string, float?> GetGPUInfo(Computer computer)
        {
            Dictionary<string, float?> GPUData = new Dictionary<string, float?>();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        switch (sensor.SensorType)
                        {
                            case SensorType.Load:
                                {
                                    GPUData["Load"] = sensor.Value;
                                    break;
                                }
                            case SensorType.Temperature:
                                {
                                    GPUData["Temp"] = sensor.Value;
                                    break;
                                }
                            case SensorType.Frequency:
                                {
                                    GPUData["Freq"] = sensor.Value;
                                    break;
                                }
                        }
                    }
                }
            }

            return GPUData;
        }

        private static Dictionary<string, float?> GetRAMInfo(Computer computer)
        {
            Dictionary<string, float?> RAMData = new Dictionary<string, float?>();

            foreach (var hardware in computer.Hardware)
            {
                hardware.Update();
                if (hardware.HardwareType == HardwareType.Memory)
                {
                    foreach (var sensor in hardware.Sensors)
                    {
                        switch (sensor.SensorType)
                        {
                            case SensorType.Frequency:
                                {
                                    RAMData["Freq"] = sensor.Value;
                                    break;
                                }
                            case SensorType.Data:
                                {
                                    RAMData["Load"] = sensor.Value; // в формате "исп/своб ГБ"
                                    break;
                                }
                        }
                    }
                }
            }

            return RAMData;
        }
    }
}
