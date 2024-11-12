namespace Assignment_2___Dawn_Bosing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            ScatterPlotControl scatterPlot = new ScatterPlotControl
            {
                Dock = DockStyle.Fill
            };

            scatterPlot.AddDataPoint(1, 2, 0);
            scatterPlot.AddDataPoint(2, 3, 1);
            scatterPlot.AddDataPoint(4, 1, 2);
            scatterPlot.AddDataPoint(3, 5, 0);
            scatterPlot.AddDataPoint(5, 4, 3);

            this.Controls.Add(scatterPlot);
        }
    }
}
