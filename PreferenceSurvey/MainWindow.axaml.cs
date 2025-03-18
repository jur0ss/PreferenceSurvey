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

    
    
    public MainWindow()
    {
        InitializeComponent();

        DataButton.Click += DataButton_Click;
        SubmitButton.Click += SubmitButton_Click;
    }

    private void DataButton_Click(object sender, RoutedEventArgs e)
    {
        if (string.IsNullOrEmpty(TextBox1.Text))
        {
            var content = "Błąd";
            Info.Text = content;
        }
        else
        {
            var content = "Zatwierdzono dane";
            Info.Text = content;
        }
        ;
    }

    private void SubmitButton_Click(object sender, RoutedEventArgs e)
    {
        try
        {

            var textBox1Value = TextBox1.Text;
            
            var comboBoxValue = (ComboBox.SelectedItem as ComboBoxItem)?.Content?.ToString() ?? "Nie wybrano odpowiedzi";

            var textBox2Value = TextBox2.Text ?? "Nie udzielono odpowiedzi";

            var checkBox1Value = CheckBox1.IsChecked == true ? CheckBox1.Content.ToString() : "";
            
            var checkBox2Value = CheckBox2.IsChecked == true ? CheckBox2.Content.ToString() : "";
            
            var checkBox3Value = CheckBox3.IsChecked == true ? CheckBox3.Content.ToString() : "";
            
            var checkBox4Value = CheckBox4.IsChecked == true ? CheckBox4.Content.ToString() : "";

            var content = $"Imię: {textBox1Value}\n" +
                          $"Zainteresowanie: {comboBoxValue}\n" +
                          $" W programowaniu lubisz: {textBox2Value}" +
                          $"\n Języki które lubisz: {checkBox1Value} | {checkBox2Value} | {checkBox3Value} | {checkBox4Value}"
                          ;

            Info.Text = content;


        }
        catch (Exception exception)
        {
            Console.WriteLine(exception);
            throw;
        }
    }
    
    
    
}
