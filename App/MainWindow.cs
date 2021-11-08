using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using App.View;
using App.ViewModels;
using App.Interface;
using App.DataServices;
using System.Threading;

namespace App
{
    public partial class MainWindow : Form
    {
        private BaseView _view;          
        private BaseSectorViewModel _model;
        private IDataAccess data;

        public MainWindow()
        {
            data = new SqlDataAccess("../../../sqlite.db");
            
            InitializeComponent();
            softName.BringToFront();
        }
        // Anti flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }
        private void SwapView(Models.TypeOfSoftware view=Models.TypeOfSoftware.None)
        {
            if (view != Models.TypeOfSoftware.None)
            {
                contentPanel.Controls.Remove(_view);
                switch (view){
                    case Models.TypeOfSoftware.Design:
                        _model = new DesignSectorViewModel(data);
                        _view = new DesignSectorView(_model as DesignSectorViewModel);
                        break;
                    case Models.TypeOfSoftware.IT:
                        _model = new ITSectorViewModel(data);
                        _view = new ITSectorView(_model as ITSectorViewModel);
                        break;
                    case Models.TypeOfSoftware.Tech:
                        _model = new TechnologySectorViewModel(data);
                        _view = new TechnologySectorView(_model as TechnologySectorViewModel);
                        break;
                    default:
                        _model = null;
                        _view = new HomeView();
                        break;
                }
            }
            contentPanel.Controls.Add(_view);
        }

        private void changeButtonColorAndShowTab(dynamic button, dynamic buttonA, dynamic buttonB)
        {
            if (button.Normalcolor != button.Activecolor)
            {
                contentPanel.Show();
                contentPanel.BringToFront();
                menuPanel.Width = 350;
                contentPanel.Left = 350;
                ITTab.ButtonText = "  CÔNG NGHỆ THÔNG TIN";
                MultimediaTab.ButtonText = "  ĐỒ HỌA KỸ THUẬT SỐ";
                TechnicalityTab.ButtonText = "  KỸ THUẬT";
                menuPanel.BringToFront();
                button.Normalcolor = button.Activecolor;
                buttonA.Normalcolor = buttonB.Normalcolor = Color.Transparent;
            }
            else
            {
                contentPanel.Hide();
                menuPanel.Width = 135;
                ITTab.ButtonText = "";
                MultimediaTab.ButtonText = "";
                TechnicalityTab.ButtonText = "";
                button.Normalcolor = Color.Transparent;
            }
        }

        private void menuButton_Click(dynamic sender, EventArgs e)
        {
            if (menuPanel.Width == 135)
            {
                menuPanel.Width = 350;
                contentPanel.Left = 350;
                ITTab.ButtonText = "  CÔNG NGHỆ THÔNG TIN";
                MultimediaTab.ButtonText = "  ĐỒ HỌA KỸ THUẬT SỐ";
                TechnicalityTab.ButtonText = "  KỸ THUẬT";
            }
            else
            {
                contentPanel.Left = 236;
                menuPanel.Width = 135;
                ITTab.ButtonText = "";
                MultimediaTab.ButtonText = "";
                TechnicalityTab.ButtonText = "";
            }
        }
        private void ITTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, TechnicalityTab, MultimediaTab);
            SwapView(Models.TypeOfSoftware.IT);
        }
        private void TechnicalityTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, ITTab, MultimediaTab);
            SwapView(Models.TypeOfSoftware.Tech);
        }
        private void MultimediaTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, ITTab, TechnicalityTab);
            SwapView(Models.TypeOfSoftware.Design);
        }

        private void FadeOut(Form o, int time = 300)
        {
            while (o.Opacity > 0.0)
            {
                Thread.Sleep(time / 100);
                o.Opacity -= 0.05;
            }
            o.Opacity = 0;
        }
        private void exitButton_Click(object sender, EventArgs e)
        {
            FadeOut(this, 300);
            Application.Exit();
        }
        private void minimizeButton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void GithubButton_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/phanxuanquang/autoStudent");
        }
    }
}
