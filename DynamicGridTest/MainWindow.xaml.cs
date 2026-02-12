using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;
using System.Collections.Generic;

namespace DynamicGridTest
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            PopulateCharts(6); // Default 6 charts
        }

        private string _currentStrategy = "GridLandscape";

        private void ChartCount_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (MainGrid == null) return; // Prevent firing before UI is ready

            if (ChartCountCombo.SelectedItem is ComboBoxItem item && int.TryParse(item.Content.ToString(), out int count))
            {
                PopulateCharts(count);
                ApplyLayout(_currentStrategy); // Maintain current strategy
            }
        }

        private void LayoutRadioButton_Click(object sender, RoutedEventArgs e)
        {
            if (sender is RadioButton rb && rb.Tag is string strategy)
            {
                _currentStrategy = strategy;
                ApplyLayout(strategy);
            }
        }

        private void ApplyLayout(string strategy)
        {
            int count = MainGrid.Children.Count;
            if (count == 0) return;

            switch (strategy)
            {
                case "StackHorizontal": // 1 Row
                    MainGrid.Rows = 1;
                    MainGrid.Columns = count;
                    break;
                case "StackVertical": // 1 Column
                    MainGrid.Rows = count;
                    MainGrid.Columns = 1;
                    break;
                case "GridPortrait":
                    // Optimize for Height (Rows >= Cols)
                    if (count == 1) { MainGrid.Rows = 1; MainGrid.Columns = 1; }
                    else if (count == 2) { MainGrid.Rows = 2; MainGrid.Columns = 1; }
                    else if (count == 3) { MainGrid.Rows = 3; MainGrid.Columns = 1; } // or 2x2
                    else if (count == 4) { MainGrid.Rows = 2; MainGrid.Columns = 2; }
                    else if (count <= 6) { MainGrid.Rows = 3; MainGrid.Columns = 2; }
                    else { MainGrid.Rows = 0; MainGrid.Columns = 0; }
                    break;
                case "GridLandscape":
                default:
                    // Optimize for Width (Cols >= Rows)
                    if (count == 1) { MainGrid.Rows = 1; MainGrid.Columns = 1; }
                    else if (count == 2) { MainGrid.Rows = 1; MainGrid.Columns = 2; }
                    else if (count == 3) { MainGrid.Rows = 1; MainGrid.Columns = 3; }
                    else if (count == 4) { MainGrid.Rows = 2; MainGrid.Columns = 2; }
                    else if (count <= 6) { MainGrid.Rows = 2; MainGrid.Columns = 3; }
                    else { MainGrid.Rows = 0; MainGrid.Columns = 0; }
                    break;
            }
        }

        private void PopulateCharts(int count)
        {
            MainGrid.Children.Clear();
            for (int i = 0; i < count; i++)
            {
                MainGrid.Children.Add(new ChartingControl());
            }
        }
    }
}