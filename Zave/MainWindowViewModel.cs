﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Zave.MVVM.View.MainWindow
{
    public static class MainWindowViewModel
    {
        //public static ZDFEntry.ZDFEntry ZdfEntry { get; set; }





        public static void setTextBoxes(ZaveModel.ZDFSource.Source zsrc)
        {
            ((Zave.MainWindow)System.Windows.Application.Current.Windows[0]).MainWin.docNameTxtBx.Text = zsrc.DocName;
            ((Zave.MainWindow)System.Windows.Application.Current.Windows[0]).MainWin.docPgNmbrTxtBx.Text = zsrc.DocPage;
            ((Zave.MainWindow)System.Windows.Application.Current.Windows[0]).MainWin.docTextTxtBx1.Text = zsrc.DocText;
        }
    }
}
