using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace PreferenceSurvey;

public partial class MainWindow : Window
{


    private List<ComboBox> _groupCombo;
    
    public MainWindow()
    {
        InitializeComponent();

        SubmitButton.Click += SubmitButton_Click;
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {

            var textBoxValue = TextBox1.Text ?? "Nie wpisano imienia";
            
            var comboBoxValue = (ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Nie wybrano odpowiedzi";
            
            var textBox2Value = TextBox2.Text ?? "Nie udzielono odpowiedzi"


        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
    
    
    
}
