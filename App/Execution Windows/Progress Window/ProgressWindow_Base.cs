using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace App
{
    public partial class ProgressWindow_Base : Form
    {
        private static RunBackground runBackground;
        protected List<Package> listSoftware;
        protected List<ActionProcess> blackList;
        protected int countCompletedAmount;
        protected bool HasExitTodoTask;
        public enum StatusDataGridView
        {
            None,
            Ready,
            Downloading,
            Installing,
            Uninstalling,
            Completed,
            Canceled,
            Failed
        }
        public enum ActionProcess
        {
            Done,
            Canceled,
            None
        }

        public ProgressWindow_Base(List<Package> listSoftware) : this()
        {
            this.listSoftware = listSoftware;
            countCompletedAmount = 0;
            UpdateCompletedAmount(countCompletedAmount);

            blackList = new List<ActionProcess>();
            for (int index = 0; index < this.listSoftware.Count; index++)
            {
                blackList.Add(ActionProcess.None);
            }
        }
        public ProgressWindow_Base()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            if (runBackground == null)
            {
                runBackground = new RunBackground(this, this.components);
            }
        }

        //Anti Flickering
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;
                return handleParam;
            }
        }

        protected virtual void LoadDataGridView() { }
        protected virtual void ToDo() { }

        protected void UpdateCompletedAmount(int value)
        {
            if (listSoftware != null && value >= 0)
            {
                try
                {
                    progressBar.Value = Convert.ToInt32(value * 100.0f / listSoftware.Count);
                    completedAmountLabel.Text = String.Format("{0}/{1}", value, listSoftware.Count);
                }
                catch
                {
                    progressBar.BeginInvoke(new Action(() =>
                    {
                        progressBar.Value = Convert.ToInt32(value * 100.0f / listSoftware.Count);
                    }));
                    completedAmountLabel.BeginInvoke(new Action(() =>
                    {
                        completedAmountLabel.Text = String.Format("{0}/{1}", value, listSoftware.Count);
                    }));
                }
            }
        }

        protected Image GetImageStatus(StatusDataGridView status)
        {
            Image result = null;
            switch (status)
            {
                case StatusDataGridView.Ready:
                    break;
                case StatusDataGridView.Downloading:
                    break;
                case StatusDataGridView.Installing:
                    break;
                case StatusDataGridView.Uninstalling:
                    break;
                case StatusDataGridView.Completed:
                    break;
                case StatusDataGridView.Canceled:
                    break;
                case StatusDataGridView.Failed:
                    break;
                case StatusDataGridView.None:
                    break;
            }
            return result;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            softwareGridView.Visible = !softwareGridView.Visible;
        }

        protected void UpdateStatusProcess(int index, StatusDataGridView status)
        {
            UpdateActionButton(index, status);
            if (listSoftware != null && index > -1 && index < listSoftware.Count)
            {
                try
                {
                    softwareGridView.Rows[index].Cells[softwareGridView.Columns.Count - 2].Value = GetImageStatus(status);
                }
                catch
                {
                    softwareGridView.BeginInvoke(new Action(() =>
                    {
                        softwareGridView.Rows[index].Cells[softwareGridView.Columns.Count - 2].Value = GetImageStatus(status);
                    }));
                }
            }
        }
        protected void UpdateActionButton(int index, StatusDataGridView status)
        {
            if (status == StatusDataGridView.Uninstalling || status == StatusDataGridView.Installing)
            {
                if (listSoftware != null && index > -1 && index < listSoftware.Count)
                {
                    try
                    {
                        ((DataGridViewDisableButtonCell)softwareGridView.Rows[index].Cells[softwareGridView.Columns.Count - 1]).Enabled = false;
                        softwareGridView.Refresh();
                    }
                    catch
                    {
                        softwareGridView.BeginInvoke(new Action(() =>
                        {
                            ((DataGridViewDisableButtonCell)softwareGridView.Rows[index].Cells[softwareGridView.Columns.Count - 1]).Enabled = false;
                            softwareGridView.Refresh();
                        }));
                    }
                }
            }
        }

        private void softwareGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && e.RowIndex < listSoftware.Count)
            {
                ActionButton_TextChanged(e.RowIndex, e.ColumnIndex, blackList[e.RowIndex] == ActionProcess.None ? ActionProcess.Canceled : ActionProcess.None);
            }
        }

        protected void ActionButton_TextChanged(int row, int column, ActionProcess action)
        {
            if (column == softwareGridView.Columns.Count - 1 && row > -1 && row < listSoftware.Count)
            {
                if (((DataGridViewDisableButtonCell)softwareGridView.Rows[row].Cells[softwareGridView.Columns.Count - 1]).Enabled)
                {
                    string value = "";
                    switch (action)
                    {
                        case ActionProcess.None:
                            value = "HỦY";
                            break;
                        case ActionProcess.Done:
                            value = "HỦY";
                            break;
                        case ActionProcess.Canceled:
                            value = "KHÔI PHỤC";
                            break;
                    }
                    try
                    {
                        softwareGridView.Rows[row].Cells[softwareGridView.Columns.Count - 1].Value = value;
                    }
                    catch
                    {
                        softwareGridView.BeginInvoke(new Action(() =>
                        {
                            softwareGridView.Rows[row].Cells[softwareGridView.Columns.Count - 1].Value = value;
                        }));
                    }
                    blackList[row] = action;
                    if (blackList[row] == ActionProcess.None && HasExitTodoTask)
                    {
                        ToDo();
                    }
                }
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            if (HasExitTodoTask)
            {
                this.Close();
            }
            else backgroundRunning_Button_Click(null, null);
        }

        private void cancelAll_Button_Click(object sender, EventArgs e)
        {
            for(int index = 0; index < blackList.Count; index++)
            {
                ActionButton_TextChanged(index, softwareGridView.Columns.Count - 1, ActionProcess.Canceled);
            }
        }

        private void backgroundRunning_Button_Click(object sender, EventArgs e)
        {
            if (runBackground != null)
            {
                runBackground.EnableRunBackground(Program.setting.timeSetter);
            }
        }
    }

    /// <summary>
    /// Disable button data grid view
    /// link: https://docs.microsoft.com/en-us/dotnet/desktop/winforms/controls/disable-buttons-in-a-button-column-in-the-datagrid?view=netframeworkdesktop-4.8
    /// </summary>
    public class DataGridViewDisableButtonColumn : DataGridViewButtonColumn
    {
        public DataGridViewDisableButtonColumn()
        {
            this.CellTemplate = new DataGridViewDisableButtonCell();
        }
    }

    public class DataGridViewDisableButtonCell : DataGridViewButtonCell
    {
        private bool enabledValue;
        public bool Enabled
        {
            get
            {
                return enabledValue;
            }
            set
            {
                enabledValue = value;
            }
        }

        // Override the Clone method so that the Enabled property is copied.
        public override object Clone()
        {
            DataGridViewDisableButtonCell cell =
                (DataGridViewDisableButtonCell)base.Clone();
            cell.Enabled = this.Enabled;
            return cell;
        }

        // By default, enable the button cell.
        public DataGridViewDisableButtonCell()
        {
            this.enabledValue = true;
        }

        protected override void Paint(Graphics graphics,
            Rectangle clipBounds, Rectangle cellBounds, int rowIndex,
            DataGridViewElementStates elementState, object value,
            object formattedValue, string errorText,
            DataGridViewCellStyle cellStyle,
            DataGridViewAdvancedBorderStyle advancedBorderStyle,
            DataGridViewPaintParts paintParts)
        {
            // The button cell is disabled, so paint the border,
            // background, and disabled button for the cell.
            if (!this.enabledValue)
            {
                // Draw the cell background, if specified.
                if ((paintParts & DataGridViewPaintParts.Background) ==
                    DataGridViewPaintParts.Background)
                {
                    SolidBrush cellBackground =
                        new SolidBrush(cellStyle.BackColor);
                    graphics.FillRectangle(cellBackground, cellBounds);
                    cellBackground.Dispose();
                }

                // Draw the cell borders, if specified.
                if ((paintParts & DataGridViewPaintParts.Border) ==
                    DataGridViewPaintParts.Border)
                {
                    PaintBorder(graphics, clipBounds, cellBounds, cellStyle,
                        advancedBorderStyle);
                }

                // Calculate the area in which to draw the button.
                Rectangle buttonArea = cellBounds;
                Rectangle buttonAdjustment =
                    this.BorderWidths(advancedBorderStyle);
                buttonArea.X += buttonAdjustment.X;
                buttonArea.Y += buttonAdjustment.Y;
                buttonArea.Height -= buttonAdjustment.Height;
                buttonArea.Width -= buttonAdjustment.Width;

                // Draw the disabled button.
                ButtonRenderer.DrawButton(graphics, buttonArea,
                    PushButtonState.Disabled);

                // Draw the disabled button text.
                if (this.FormattedValue is String)
                {
                    TextRenderer.DrawText(graphics,
                        (string)this.FormattedValue,
                        this.DataGridView.Font,
                        buttonArea, SystemColors.GrayText);
                }
            }
            else
            {
                // The button cell is enabled, so let the base class
                // handle the painting.
                base.Paint(graphics, clipBounds, cellBounds, rowIndex,
                    elementState, value, formattedValue, errorText,
                    cellStyle, advancedBorderStyle, paintParts);
            }
        }
    }
}
