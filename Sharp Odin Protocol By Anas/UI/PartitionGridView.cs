using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Sharp_Odin_Protocol_By_Anas.Flash;

namespace Sharp_Odin_Protocol_By_Anas.UI
{
    public sealed class PartitionGridView
    {
        // "Enable" هو العمود التلقائي اللي يبنيه الـ DataGridView من خاصية FlashFileItem.Enable (bool)
        // عند ربط DataSource. أي عمود يدوي (مثل gridViewCheckBoxColumn1) ينمسح تلقائياً
        // أول ما نسوي _grid.DataSource = ... لأن AutoGenerateColumns تبع الـ Grid = true،
        // فلازم نستخدم هذا العمود نفسه بدل ما نضيف عمود يدوي ونحاول نقرأ منه.
        private const string CheckBoxColumn = "Enable";
        private readonly DataGridView _grid;

        public PartitionGridView(DataGridView grid)
        {
            _grid = grid;
            _grid.AutoGenerateColumns = true; // صريح بدل الاعتماد على الافتراضي
            _grid.CellFormatting += OnCellFormatting;
        }

        public void LoadFiles(IList<FlashFileItem> files)
        {
            _grid.DataSource = null;
            _grid.DataSource = files.ToList();
            ConfigureColumns();
        }

        public void CheckAll()
        {
            for (int i = 0; i < _grid.Rows.Count; i++)
            {
                _grid.Rows[i].Cells[CheckBoxColumn].Value = true;
            }

            foreach (var item in _grid.DataSource as IEnumerable<FlashFileItem> ?? Enumerable.Empty<FlashFileItem>())
            {
                item.Enable = true;
            }
        }

        public List<FlashFileItem> GetCheckedFiles()
        {
            var files = new List<FlashFileItem>();

            foreach (DataGridViewRow row in _grid.Rows)
            {
                if (row.IsNewRow)
                {
                    continue;
                }

                bool isChecked = Convert.ToBoolean(row.Cells[CheckBoxColumn].Value ?? false);

                if (isChecked && row.DataBoundItem is FlashFileItem item)
                {
                    item.Enable = true;
                    files.Add(item);
                }
            }

            return files;
        }

        public void CommitEdits()
        {
            _grid.EndEdit();
        }

        public void Clear()
        {
            _grid.DataSource = null;
        }

        private void ConfigureColumns()
        {
            if (_grid.Columns["FilePath"] != null)
            {
                _grid.Columns["FilePath"].Visible = false;
            }

            if (_grid.Columns["RawSize"] != null)
            {
                _grid.Columns["RawSize"].Visible = false;
            }

            if (_grid.Columns["PackageType"] != null)
            {
                _grid.Columns["PackageType"].Visible = true;
                _grid.Columns["PackageType"].HeaderText = "Package";
                _grid.Columns["PackageType"].ReadOnly = true;
            }

            if (_grid.Columns["FileName"] != null)
            {
                _grid.Columns["FileName"].HeaderText = "File Name";
                _grid.Columns["FileName"].ReadOnly = true;
            }

            if (_grid.Columns["DisplaySize"] != null)
            {
                _grid.Columns["DisplaySize"].HeaderText = "Size";
                _grid.Columns["DisplaySize"].ReadOnly = true;
            }

            if (_grid.Columns["Enable"] != null)
            {
                _grid.Columns["Enable"].HeaderText = "";
                _grid.Columns["Enable"].Width = 50;
                _grid.Columns["Enable"].DisplayIndex = 0;
                _grid.Columns["Enable"].Resizable = DataGridViewTriState.False;
                // ملاحظة: ما نخفيه — هذا هو عمود الـ Checkbox الفعلي والمربوط فعلياً بـ item.Enable
            }
        }

        private void OnCellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
            {
                return;
            }

            var grid = (DataGridView)sender;
            string columnName = grid.Columns[e.ColumnIndex].Name;

            if (columnName != "PackageType" && columnName != "FileName")
            {
                return;
            }

            string packageType = grid.Rows[e.RowIndex].Cells["PackageType"]?.Value?.ToString();

            if (packageType == "AP")
            {
                e.CellStyle.ForeColor = Color.FromArgb(192, 0, 0);
                e.CellStyle.SelectionForeColor = Color.FromArgb(192, 0, 0);
            }
            else if (packageType == "BL")
            {
                e.CellStyle.ForeColor = Color.DarkOrange;
                e.CellStyle.SelectionForeColor = Color.DarkOrange;
            }
            else if (packageType == "CP")
            {
                e.CellStyle.ForeColor = Color.Black;
                e.CellStyle.SelectionForeColor = Color.Black;
            }
            else if (packageType == "CSC")
            {
                e.CellStyle.ForeColor = Color.DarkGreen;
                e.CellStyle.SelectionForeColor = Color.DarkGreen;
            }
        }
    }
}
