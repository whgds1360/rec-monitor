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

        public Dictionary<string, string>? getMetricInfo()
        {
            try
            {   
                if (this.computer is null)
                {
                    return null;
                    throw new ArgumentNullException("Ошибка инициализации сборщика метриков");
                }
                this.computer.Open();
                this.computer.Accept(new UpdateVisitor());
            }

            catch (Exception error)
            {
                MessageBox.Show($"Ошибка: {error.Message}");
            }
        }
    }
}
