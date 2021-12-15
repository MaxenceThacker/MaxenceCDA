using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace LibrairyClassInstaller
{
    [RunInstaller(true)]
    public partial class Installer1 : Installer
    {
        public Installer1()
        {
            InitializeComponent();
        }
    }

    public override void Install(IDictionary stateSaver)
    {
        base.Install(stateSaver);
        string param = this.Context.Parameters["base"];
        File.WriteAllText("C:\\Users\\1701871\\Desktop\\connexion.json", param);
    }
}
