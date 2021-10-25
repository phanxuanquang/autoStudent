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
            data = new SqlDataAccess("connect");
            
            InitializeComponent();
        }

        private void SwapView(BaseView view = null)
        {
            if (view != null)
            {
                this.Controls.Remove(_view);

                if (view is DesignSectorView)
                {
                    _model = new DesignSectorViewModel(data);
                    _view = new DesignSectorView(_model as DesignSectorViewModel);
                }

                // If the View an OtherView
                if (view is ITSectorView)
                {
                    _model = new ITSectorViewModel(data);
                    _view = new ITSectorView(_model as ITSectorViewModel);
                }

                if (view is TechnologySectorView)
                {
                    _model = new TechnologySectorViewModel(data);
                    _view = new TechnologySectorView(_model as TechnologySectorViewModel);
                }

                if (view is HomeView)
                {
                    _model = null;
                    _view = new HomeView();
                }
            }
            contentPanel.Controls.Add(_view);

        }

        private void changeButtonColorAndShowTab(dynamic button, dynamic buttonA, dynamic buttonB)
        {
            if (button.Normalcolor != button.Activecolor)
            {
                menuPanel.Width = 350;
                contentPanel.Show();
                softName.Hide();
                button.Normalcolor = button.Activecolor;
                buttonA.Normalcolor = Color.Transparent;
                buttonB.Normalcolor = Color.Transparent;
            }
            else
            {
                menuPanel.Width = 135;
                menuButton.Enabled = true;
                contentPanel.Hide();
                softName.Show();
                button.Normalcolor = Color.Transparent;
            }
        }

        private void menuButton_Click(dynamic sender, EventArgs e)
        {
            if (menuPanel.Width == 135)
            {
                contentPanel.Show();
                softName.Hide();
                menuPanel.Width = 350;
            }
            else
            {
                contentPanel.Hide();
                softName.Show();
                menuPanel.Width = 135;
            }
        }
        private void ITTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, TechnicalityTab, MultimediaTab);
            SwapView(new ITSectorView());
        }
        private void TechnicalityTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, ITTab, MultimediaTab);
            SwapView(new TechnologySectorView());
        }
        private void MultimediaTab_Click(object sender, EventArgs e)
        {
            changeButtonColorAndShowTab(sender, ITTab, TechnicalityTab);
            SwapView(new DesignSectorView());
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
