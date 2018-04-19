using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor;
using OpenHardwareMonitor.Hardware;

namespace Test_001
{

    public partial class SystemWatch : Form//MetroFramework.Forms.MetroForm
    {
        Computer thisComputer;
        // List<ISensor> cpuTempSensorList = new List<ISensor>();
        // List<ISensor> cpuLoadSensorList = new List<ISensor>();
        ISensor cpuTempSensor;
        ISensor cpuLoadSensor;
        ISensor gpuTempSensor;
        ISensor gpuLoadSensor;
        int[] cpuTempValues = new int[60];
        int[] cpuLoadValues = new int[60];
        int[] gpuTempValues = new int[60];
        int[] gpuLoadValues = new int[60];
        Color lineColor = Color.FromArgb(82, 113, 134);
        Color areaColor = Color.FromArgb(128, 134, 217, 225);
        Color areaColor_Red = Color.FromArgb(128, 224,134, 206);
        Color bgColor = Color.FromArgb(40, 74, 99);
        int cupTempWarningValue = 85;
        int cupLoadWarningValue = 90;
        int gupTempWarningValue = 85;
        int gupLoadWarningValue = 90;
        bool isCPUTempHigh = false;
        bool isCPULoadHigh = false;
        bool isGPUTempHigh = false;
        bool isGPULoadHigh = false;
        int cpuTemp = 0;
        int cpuLoad = 0;
        int gpuTemp = 0;
        int gpuLoad = 0;
        int[] Dots;


        public SystemWatch()
        {
            InitializeComponent();
            InitializeGraphics();
        }

        private void InitializeGraphics()
        {
            //====================BG  ======================
            this.BackColor = bgColor;
            //============CPU Temp Chart======================
            label_CPU_Temp.ForeColor = areaColor;
            
            CPU_Chart.BackColor = bgColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisX.TitleForeColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisX.LineColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = lineColor;

            CPU_Chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisY.TitleForeColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisY.LineColor = lineColor;
            CPU_Chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = lineColor;

            CPU_Chart.ChartAreas["ChartArea1"].BackColor = bgColor;

            CPU_Chart.Series["Series1"].Color = areaColor;
            CPU_Chart.Series["Series1"].BorderColor = areaColor;
            CPU_Chart.Series["Series1"].BorderWidth = 3;

            //============CPU Load Chart======================
            label_CPU_Load.ForeColor = areaColor;

            CPU_Chart2.BackColor = bgColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisX.TitleForeColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisX.LineColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = lineColor;

            CPU_Chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisY.TitleForeColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisY.LineColor = lineColor;
            CPU_Chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = lineColor;

            CPU_Chart2.ChartAreas["ChartArea1"].BackColor = bgColor;

            CPU_Chart2.Series["Series1"].Color = areaColor;
            CPU_Chart2.Series["Series1"].BorderColor = areaColor;
            CPU_Chart2.Series["Series1"].BorderWidth = 3;

            //============GPU Temp Chart======================
            label_GPU_Temp.ForeColor = areaColor;

            GPU_Chart.BackColor = bgColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisX.TitleForeColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisX.LineColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = lineColor;

            GPU_Chart.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisY.TitleForeColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisY.LineColor = lineColor;
            GPU_Chart.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = lineColor;

            GPU_Chart.ChartAreas["ChartArea1"].BackColor = bgColor;

            GPU_Chart.Series["Series1"].Color = areaColor;
            GPU_Chart.Series["Series1"].BorderColor = areaColor;
            GPU_Chart.Series["Series1"].BorderWidth = 3;

            //============GPU Temp Chart======================
            label_GPU_Load.ForeColor = areaColor;

            GPU_Chart2.BackColor = bgColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisX.MajorGrid.LineColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisX.TitleForeColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisX.LineColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisX.LabelStyle.ForeColor = lineColor;

            GPU_Chart2.ChartAreas["ChartArea1"].AxisY.MajorGrid.LineColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisY.TitleForeColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisY.LineColor = lineColor;
            GPU_Chart2.ChartAreas["ChartArea1"].AxisY.LabelStyle.ForeColor = lineColor;

            GPU_Chart2.ChartAreas["ChartArea1"].BackColor = bgColor;

            GPU_Chart2.Series["Series1"].Color = areaColor;
            GPU_Chart2.Series["Series1"].BorderColor = areaColor;
            GPU_Chart2.Series["Series1"].BorderWidth = 3;

        }

        private void setCPUTempColor(Color color)
        {
            CPU_Chart.Series["Series1"].Color = color;
            CPU_Chart.Series["Series1"].BorderColor = color;
            
        }
        private void setCPULoadColor(Color color)
        {
            CPU_Chart2.Series["Series1"].Color = color;
            CPU_Chart2.Series["Series1"].BorderColor = color;
        }
        private void setGPUTempColor(Color color)
        {
            GPU_Chart.Series["Series1"].Color = color;
            GPU_Chart.Series["Series1"].BorderColor = color;
            
        }
        private void setGPULoadColor(Color color)
        {
            GPU_Chart2.Series["Series1"].Color = color;
            GPU_Chart2.Series["Series1"].BorderColor = color;
        }

        private void Test_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < cpuTempValues.Length; i++)
            {
                cpuTempValues[i] = 0;
            }
            for (int i = 0; i < cpuLoadValues.Length; i++)
            {
                cpuLoadValues[i] = 0;
            }
            for (int i = 0; i < gpuLoadValues.Length; i++)
            {
                gpuLoadValues[i] = 0;
            }
            for (int i = 0; i < gpuTempValues.Length; i++)
            {
                gpuTempValues[i] = 0;
            }

            thisComputer = new Computer();
            thisComputer.Open();
            thisComputer.GPUEnabled = true;
            thisComputer.CPUEnabled = true;

            assign_Sensors();

            timer1.Start();
        }

        private void assign_Sensors()
        {
            for (int i = 0; i < thisComputer.Hardware.Length; i++)
            {
                if (thisComputer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < thisComputer.Hardware[i].Sensors.Length; j++)
                    {
                        //找到温度
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {

                            if (thisComputer.Hardware[i].Sensors[j].Name.Contains("Package"))
                            {
                                cpuTempSensor = thisComputer.Hardware[i].Sensors[j];
                            }

                        }
                        //找到load
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            
                            if (thisComputer.Hardware[i].Sensors[j].Name.Contains("Total"))
                            {
                                cpuLoadSensor = thisComputer.Hardware[i].Sensors[j];
                            }
                        }
                    }
                }
                else if (thisComputer.Hardware[i].HardwareType == HardwareType.GpuNvidia || thisComputer.Hardware[i].HardwareType == HardwareType.GpuAti)
                {
                    for (int j = 0; j < thisComputer.Hardware[i].Sensors.Length; j++)
                    {
                        //找到温度
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {
                            gpuTempSensor = thisComputer.Hardware[i].Sensors[j];
                        }
                        //找到load
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {
                            gpuLoadSensor = thisComputer.Hardware[i].Sensors[j];
                        }
                    }
                }
            }
            
        }
        
        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 
            /*
            foreach (var hardwareItem in thisComputer.Hardware)
            {
                hardwareItem.Update();
                foreach (var sensor in hardwareItem.Sensors)
                {
                    if (sensor.SensorType == SensorType.Load)
                    {

                        label_GPU_Load.Text = String.Format("{0} {1} {2} = {3}", sensor.Name, sensor.Hardware, sensor.SensorType, sensor.Value);
                    }
                }
                
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia)
                {
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            label_GPU_Temp.Text = String.Format("The current GPU temperature is {0}", sensor.Value);
                        }
                    }
                }
            }

            for (int i = 0; i < thisComputer.Hardware.Length; i++)
            {

                //循环找到HardwareType为cpu
                if (thisComputer.Hardware[i].HardwareType == HardwareType.CPU)
                {
                    for (int j = 0; j < thisComputer.Hardware[i].Sensors.Length; j++)
                    {

                        //找到温度
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Temperature)
                        {

                            //获取到cpu核心
                            str_cpu_temp.Append(thisComputer.Hardware[i].Sensors[j].Name);
                            str_cpu_temp.Append("\t : ");

                            //这里就是cpu温度了
                            str_cpu_temp.Append(thisComputer.Hardware[i].Sensors[j].Value.ToString());
                            str_cpu_temp.Append("\n");
                        }
                        //找到load
                        if (thisComputer.Hardware[i].Sensors[j].SensorType == SensorType.Load)
                        {

                            //获取到cpu核心
                            str_cpu_load.Append(thisComputer.Hardware[i].Sensors[j].Name);
                            str_cpu_load.Append("\t : ");

                            //这里就是cpu load
                            str_cpu_load.Append(thisComputer.Hardware[i].Sensors[j].Value.ToString());
                            str_cpu_load.Append("\n");
                        }

                    }
                }
            }

            // label_CPU_Temp.Text = str_cpu_temp.ToString();



             
            for (int i = 0; i < cpuTempSensorList.Count; i++) 
            {
                //"CPU Package" Temp for all the Cores
                if(cpuTempSensorList[i].Name.Contains("Package"))
                {
                    cpuTemp = (int)cpuTempSensorList[i].Value;
                }
            }
            for (int i = 0; i < cpuLoadSensorList.Count; i++)
            {
                //"CPU Total"  Load for all the Cores
                if (cpuLoadSensorList[i].Name.Contains("Total"))
                {
                    cpuLoad = (int)cpuLoadSensorList[i].Value;
                }
            }
            
            */
            #endregion
            //==================update the data=======================
            foreach (var hardwareItem in thisComputer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.GpuNvidia || hardwareItem.HardwareType == HardwareType.CPU)
                {
                    hardwareItem.Update();
                }
            }
            //===================  CPU Temp Display =====================
            cpuTemp = (int)cpuTempSensor.Value;
            label_CPU_Temp.Text = String.Format("The current CPU temp is {0} ℃", cpuTemp);

            if (cpuTemp > cupTempWarningValue)
            {
                if (!isCPUTempHigh)
                {
                    isCPUTempHigh = true;
                    setCPUTempColor(areaColor_Red);
                }
            }
            else
            {
                if (isCPUTempHigh)
                {
                    isCPUTempHigh = false;
                    setCPUTempColor(areaColor);
                }
            }
            
            Dots = updateValue(cpuTemp, cpuTempValues);
            CPU_Chart.Series["Series1"].Points.Clear();
            foreach (var dot in Dots)
            {
                CPU_Chart.Series["Series1"].Points.AddY(dot);
            }

            //===================  CPU Load Display =====================
            cpuLoad = (int)cpuLoadSensor.Value;
            label_CPU_Load.Text = String.Format("The current CPU load is {0} %", cpuLoad);
            if (cpuLoad > cupLoadWarningValue)
            {
                if (!isCPULoadHigh)
                {
                    isCPULoadHigh = true;
                    setCPULoadColor(areaColor_Red);
                }
            }else
            {
                if (isCPULoadHigh)
                {
                    isCPULoadHigh = false;
                    setCPULoadColor(areaColor);
                }
            }

            Dots = updateValue(cpuLoad, cpuLoadValues);
            CPU_Chart2.Series["Series1"].Points.Clear();
            foreach (var dot in Dots)
            {
                CPU_Chart2.Series["Series1"].Points.AddY(dot);
            }

            //===================  GPU Load Display =====================
            gpuTemp = (int)gpuTempSensor.Value;
            label_GPU_Temp.Text = String.Format("The current GPU temp is {0} ℃", gpuTemp);
            if (gpuTemp > gupTempWarningValue)
            {
                if (!isGPUTempHigh)
                {
                    isGPUTempHigh = true;
                    setGPUTempColor(areaColor_Red);
                }
            }
            else
            {
                if (isGPUTempHigh)
                {
                    isGPUTempHigh = false;
                    setGPUTempColor(areaColor);
                }
            }
            Dots = updateValue(gpuTemp, gpuTempValues);
            GPU_Chart.Series["Series1"].Points.Clear();
            foreach (var dot in Dots)
            {
                GPU_Chart.Series["Series1"].Points.AddY(dot);
            }

            //===================  GPU Load Display =====================
            gpuLoad = (int)gpuLoadSensor.Value;
            label_GPU_Load.Text = String.Format("The current GPU load is {0} %", gpuLoad);
            if (gpuLoadSensor.Value > gupLoadWarningValue)
            {
                if (!isGPULoadHigh)
                {
                    isGPULoadHigh = true;
                    setGPULoadColor(areaColor_Red);
                }
            }
            else
            {
                if (isGPULoadHigh)
                {
                    isGPULoadHigh = false;
                    setGPULoadColor(areaColor);
                }
            }
            Dots = updateValue((int)gpuLoadSensor.Value, gpuLoadValues);
            GPU_Chart2.Series["Series1"].Points.Clear();
            foreach (var dot in Dots)
            {
                GPU_Chart2.Series["Series1"].Points.AddY(dot);
            }
        }
        
        private int[] updateValue(int newValue, int[] values)
        {
            for (int i = 0; i < values.Length-1; i++)
            {
                values[i] = values[i + 1];
            }
            values[values.Length - 1] = newValue;
            return values;
        }
        

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }
        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void CPU_Chart2_Click(object sender, EventArgs e)
        {

        }
    }
}




