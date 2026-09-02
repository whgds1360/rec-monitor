using System;
using System.Collections.Generic;
using LibreHardwareMonitor.Hardware;

namespace SystemMonitor.features.Metric;
    internal class MetricCollector
    {
        private Computer? computer;

        public MetricCollector()
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
                System.Diagnostics.Debug.WriteLine($"Ошибка инициализации сборщика метриков: {error.Message}");
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
                System.Diagnostics.Debug.WriteLine($"Ошибка: {error.Message}");
                return null;
            }
        }

        private static float? GetSensorValue(IHardware hardware, SensorType type, string nameContains)
        {
            foreach (var sensor in hardware.Sensors)
            {
                if (sensor.SensorType == type && sensor.Name.Contains(nameContains, StringComparison.OrdinalIgnoreCase))
                    return sensor.Value;
            }
            return null;
        }

        private static float? GetFirstSensorValue(IHardware hardware, SensorType type)
        {
            foreach (var sensor in hardware.Sensors)
            {
                if (sensor.SensorType == type)
                    return sensor.Value;
            }
            return null;
        }

        private static Dictionary<string, float?> GetCPUInfo(Computer computer)
        {
            var cpuData = new Dictionary<string, float?>();
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.Cpu) continue;
                hardware.Update();

                cpuData["Load"] = GetSensorValue(hardware, SensorType.Load, "Total")
                                  ?? GetFirstSensorValue(hardware, SensorType.Load);
                cpuData["Temp"] = GetSensorValue(hardware, SensorType.Temperature, "Package")
                                  ?? GetFirstSensorValue(hardware, SensorType.Temperature);
                cpuData["Freq"] = GetSensorValue(hardware, SensorType.Clock, "Core")
                                  ?? GetFirstSensorValue(hardware, SensorType.Frequency);
                break;
            }
            return cpuData;
        }

        private static Dictionary<string, float?> GetGPUInfo(Computer computer)
        {
            var gpuData = new Dictionary<string, float?>();
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.GpuNvidia && hardware.HardwareType != HardwareType.GpuAmd)
                    continue;
                hardware.Update();

                gpuData["Load"] = GetSensorValue(hardware, SensorType.Load, "Core")
                                  ?? GetSensorValue(hardware, SensorType.Load, "D3D")
                                  ?? GetFirstSensorValue(hardware, SensorType.Load);
                gpuData["Temp"] = GetSensorValue(hardware, SensorType.Temperature, "Core")
                                  ?? GetFirstSensorValue(hardware, SensorType.Temperature);
                gpuData["Freq"] = GetSensorValue(hardware, SensorType.Clock, "Core")
                                  ?? GetFirstSensorValue(hardware, SensorType.Frequency);
                break;
            }
            return gpuData;
        }

        private static Dictionary<string, float?> GetRAMInfo(Computer computer)
        {
            var ramData = new Dictionary<string, float?>();
            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.Memory) continue;
                hardware.Update();

                ramData["Load"] = GetSensorValue(hardware, SensorType.Load, "Memory")
                                  ?? GetFirstSensorValue(hardware, SensorType.Load);
                break;
            }
            return ramData;
        }

        /// <summary>
        /// Вспомогательный метод, который выводит список всех сенсоров у
        /// конкретного устройства. Для использования поставить <DebugMode = true>
        /// </summary>
        public static void DebugSensors()
        {
            var computer = new Computer
                {
                    IsCpuEnabled = true,
                    IsGpuEnabled = true,
                    IsMemoryEnabled = true,
                };

            computer.Open();
            computer.Accept(new UpdateVisitor());

            foreach (var hardware in computer.Hardware)
            {
                if (hardware.HardwareType != HardwareType.Cpu) continue; // Вот тут выбирать устройство у которого вывести список сенсоров.
                hardware.Update();

                System.Diagnostics.Debug.WriteLine($"=== {hardware.Name} ===");
                System.Diagnostics.Debug.WriteLine($"=== Найдены сенсоры: ===");
                foreach (var sensor in hardware.Sensors)
                {
                    System.Diagnostics.Debug.WriteLine($"Имя:{sensor.Name} Тип:({sensor.SensorType}) Значение:{sensor.Value}");
                    System.Diagnostics.Debug.WriteLine($"===================================================================");
                }
            }
        }
    }