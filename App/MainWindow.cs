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
            this.Controls.Add(_view);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SwapView(new TechnologySectorView());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SwapView(new ITSectorView());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SwapView(new DesignSectorView());
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwapView(new HomeView());
        }
    }
}
