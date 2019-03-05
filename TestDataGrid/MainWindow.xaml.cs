using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Windows;

namespace WpfTutorialSamples.DataGrid_control
{
    public partial class SimpleDataGridSample : Window
    {
        public SimpleDataGridSample()
        {
            InitializeComponent();

            List<User> users = new List<User>();
            users.Add(new User() { Id = 1, Name = "Hakim Jenkins", Birthday = new DateTime(1981, 5, 23) });
            users.Add(new User() { Id = 2, Name = "Fahiem Jenkins", Birthday = new DateTime(2007, 1, 17) });
            users.Add(new User() { Id = 3, Name = "Idris Jenkins", Birthday = new DateTime(2012, 9, 2) });

            dgSimple.ItemsSource = users;

        }

    }

    public class User
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime Birthday { get; set; }

    }
}
