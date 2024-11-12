using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;

public class ScatterPlotControl : Control
{
    // Custom data structure to represent each point
    public class PointData
    {
        public float X { get; set; }
        public float Y { get; set; }
        public int DataSetId { get; set; }

        public PointData(float x, float y, int dataSetId)
        {
            X = x;
            Y = y;
            DataSetId = dataSetId;
        }
    }

    // Collection of data points
    private List<PointData> dataPoints = new List<PointData>();

    // Color dictionary for each data set ID
    private Dictionary<int, Color> dataSetColors = new Dictionary<int, Color>
    {
        { 0, Color.Blue },
        { 1, Color.Red },
        { 2, Color.Green },
        { 3, Color.Purple }
    };

    private int highlightedIndex = -1; // Index of the currently highlighted point
    private ToolTip toolTip = new ToolTip();

    // Method to add data points to the plot
    public void AddDataPoint(float x, float y,int dataSetId)
    {
        dataPoints.Add(new PointData(x, y, dataSetId));
        Invalidate(); // Redraw the control
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        if (dataPoints.Count == 0) return; // No points to draw

        Graphics g = e.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

        // Calculate axis scaling
        float minX = dataPoints.Min(p => p.X);
        float minY = dataPoints.Min(p => p.Y);
        float maxX = dataPoints.Max(p => p.X);
        float maxY = dataPoints.Max(p => p.Y);

        float plotWidth = Width - 60; //Margin for axes
        float plotHeight = Height - 60;
        float scaleX = plotWidth / (maxX - minX);
        float scaleY = plotHeight / (maxY - minY);

        // Draw x and y axes
        g.DrawLine(Pens.Black, 40, Height - 40, Width - 20, Height - 40); // x-axis
        g.DrawLine(Pens.Black, 40, 20, 40, Height - 40); // y-axis

        // Draw each data point
        foreach(var point in dataPoints)
        {
            if (!dataSetColors.TryGetValue(point.DataSetId, out Color color))
                color = Color.Black; // Default color if ID is not found

            // Convert data point to pixel position
            float px = 40 + (point.X - minX) * scaleX;
            float py = Height - 40 - (point.Y - minY) * scaleY;

            // Draw the point
            using (Brush brush = new SolidBrush(color))
            {
                g.FillEllipse(brush, px - 4, py - 4, 8, 8); // Circle as the marker
            }
        }

        // Draw legend 
        int legendY = 20;
        foreach (var kvp in dataSetColors)
        {
            using (Brush brush = new SolidBrush(kvp.Value))
            {
                g.FillRectangle(brush, Width - 100, legendY, 10, 10);
            }
            g.DrawString($"Data Set {kvp.Key}", Font, Brushes.Black, Width - 85, legendY - 2);
            legendY += 20;
        }
    }

    // Method that identifies and focus on individual data points
    protected override void OnMouseMove(MouseEventArgs e)
    {
        base.OnMouseMove(e);

        // Find the closest point within a certain radius
        int radius = 6; // Radius within which a point is considered "hovered"
        float minX = dataPoints.Min(p => p.X);
        float minY = dataPoints.Min(p => p.Y);
        float maxX = dataPoints.Max(p => p.X);
        float maxY = dataPoints.Max(p => p.Y);

        float plotWidth = Width - 60; 
        float plotHeight = Height - 60;
        float scaleX = plotWidth / (maxX - minX);
        float scaleY = plotHeight / (maxY - minY);

        int newHighlightedIndex = -1;
        for (int i = 0; i < dataPoints.Count; i++)
        {
            var point = dataPoints[i];

            float px = 40 + (point.X - minX) * scaleX;
            float py = Height - 40 - (point.Y - minY) * scaleY;

            if (Math.Abs(e.X - px) <= radius && Math.Abs(e.Y - py) <= radius)
            {
                newHighlightedIndex = i;
                break;
            }
        }

        if (newHighlightedIndex != highlightedIndex)
        {
            highlightedIndex = newHighlightedIndex;
            Invalidate();

            if (highlightedIndex >= 0)
            {
                var point = dataPoints[highlightedIndex];
                toolTip.Show($"({point.X}, {point.Y}), Data Set: {point.DataSetId}", this, e.Location, 1000);
            } 
            else
            {
                toolTip.Hide(this);
            }
        }
    }
}