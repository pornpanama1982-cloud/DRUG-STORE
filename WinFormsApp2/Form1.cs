using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Medicine> medicineList = new List<Medicine>();
        List<CartItem> cart = new List<CartItem>();

        decimal vatRate = 0.07m;
        PrintDocument printDoc = new PrintDocument();

        public Form1()
        {
            InitializeComponent();

            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            textBoxCode.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;

            LoadMedicine();

            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            btnAdd.Click += btnAdd_Click;
            btnDelete.Click += btnDelete_Click;
            btnPrintPdf.Click += btnPrintPdf_Click;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
        }

        private void LoadMedicine()
        {
            medicineList.Clear();

            medicineList.Add(new Medicine("001", "ยาแก้แพ้", "ยาเม็ด", 50));
            medicineList.Add(new Medicine("002", "ยาฆ่าเชื้อ", "ยาเม็ด", 80));
            medicineList.Add(new Medicine("003", "ยาแก้ไอ", "ยาเม็ด", 45));
            medicineList.Add(new Medicine("004", "น้ำขาวตรากระต่าย", "ยาน้ำ", 25));
            medicineList.Add(new Medicine("005", "ยาพารา", "ยาเม็ด", 30));

            comboBox1.Items.Clear();
            foreach (var m in medicineList)
                comboBox1.Items.Add(m.Name);

            comboBox1.SelectedIndex = -1;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1) return;

            Medicine m = medicineList[comboBox1.SelectedIndex];

            textBoxCode.Text = m.Code;
            textBox2.Text = m.Category;
            textBox3.Text = m.Price.ToString("N2");
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("กรุณาเลือกสินค้า");
                return;
            }

            if (!int.TryParse(textBoxQty.Text, out int qty) || qty <= 0)
            {
                MessageBox.Show("กรุณากรอกจำนวนให้ถูกต้อง");
                return;
            }

            Medicine m = medicineList[comboBox1.SelectedIndex];

            cart.Add(new CartItem(
                m.Code,
                m.Name,
                m.Category,
                m.Price,
                qty
            ));

            RefreshGrid();
            UpdateSummary();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("กรุณาเลือกรายการที่ต้องการลบ");
                return;
            }

            int index = dataGridView1.SelectedRows[0].Index;

            if (index >= 0 && index < cart.Count)
            {
                cart.RemoveAt(index);
                RefreshGrid();
                UpdateSummary();
            }
        }

        private void RefreshGrid()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = cart;
        }

        private void UpdateSummary()
        {
            decimal subTotal = 0;
            foreach (var item in cart)
                subTotal += item.Total;

            decimal vat = subTotal * vatRate;
            decimal grandTotal = subTotal + vat;

            lblTotal.Text = "ยอดรวม: " + subTotal.ToString("N2");
            lblVat.Text = "ภาษี 7%: " + vat.ToString("N2");
            lblGrandTotal.Text = "ยอดสุทธิ: " + grandTotal.ToString("N2");
        }

        private string GenerateReceiptNo()
        {
            return "RC" + DateTime.Now.ToString("yyyyMMddHHmmss");
        }

        private void btnPrintPdf_Click(object sender, EventArgs e)
        {
            if (cart.Count == 0)
            {
                MessageBox.Show("ยังไม่มีรายการขาย");
                return;
            }

            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "PDF files (*.pdf)|*.pdf";
            saveFile.FileName = "Receipt_" + GenerateReceiptNo() + ".pdf";

            if (saveFile.ShowDialog() != DialogResult.OK)
                return;

            printDoc = new PrintDocument();
            printDoc.PrinterSettings.PrinterName = "Microsoft Print to PDF";
            printDoc.PrinterSettings.PrintToFile = true;
            printDoc.PrinterSettings.PrintFileName = saveFile.FileName;
            printDoc.PrintPage += PrintReceipt_PrintPage;

            printDoc.Print();

            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo()
            {
                FileName = saveFile.FileName,
                UseShellExecute = true
            });
        }

        private void PrintReceipt_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font titleFont = new Font("TH Sarabun New", 22, FontStyle.Bold);
            Font normalFont = new Font("TH Sarabun New", 16);

            float y = 40;

            e.Graphics.DrawString("ร้านขายยา Healthy Care", titleFont, Brushes.Black, 200, y);
            y += 40;

            e.Graphics.DrawString("วันที่: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm"),
                normalFont, Brushes.Black, 50, y);
            y += 25;

            e.Graphics.DrawString("เลขที่ใบเสร็จ: " + GenerateReceiptNo(),
                normalFont, Brushes.Black, 50, y);
            y += 35;

            decimal subTotal = 0;

            foreach (var item in cart)
            {
                e.Graphics.DrawString(
                    $"{item.Name} x{item.Quantity} @ {item.Price:N2} = {item.Total:N2}",
                    normalFont, Brushes.Black, 70, y);
                y += 22;
                subTotal += item.Total;
            }

            decimal vat = subTotal * vatRate;
            decimal grandTotal = subTotal + vat;

            y += 20;
            e.Graphics.DrawString($"ยอดรวม: {subTotal:N2}", normalFont, Brushes.Black, 350, y);
            y += 22;
            e.Graphics.DrawString($"ภาษี 7%: {vat:N2}", normalFont, Brushes.Black, 350, y);
            y += 22;
            e.Graphics.DrawString($"ยอดสุทธิ: {grandTotal:N2}", titleFont, Brushes.Black, 350, y);
        }
    }
}
