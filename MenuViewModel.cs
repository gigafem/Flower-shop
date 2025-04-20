using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using WpfApp1.Core;

internal class MenuViewModel
{
    public RelayCommand OpenMenuCommand { get; set; }
    
    public MenuViewModel()
	{
        
        OpenMenuCommand = new RelayCommand(o =>{
            Console.WriteLine("Works");
        });

    }
}
