namespace WinFormsApp2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.groupBoxProduct = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxQty = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBoxCart = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblGrandTotal = new System.Windows.Forms.Label();
            this.btnPrintPdf = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();

            this.groupBoxProduct.SuspendLayout();
            this.groupBoxCart.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();

            // lblTitle
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("TH Sarabun New", 22F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Size = new System.Drawing.Size(900, 50);
            this.lblTitle.Text = "ร้านขายยา Healthy Care";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // groupBoxProduct
            this.groupBoxProduct.Controls.Add(this.btnAdd);
            this.groupBoxProduct.Controls.Add(this.textBoxQty);
            this.groupBoxProduct.Controls.Add(this.label5);
            this.groupBoxProduct.Controls.Add(this.textBox3);
            this.groupBoxProduct.Controls.Add(this.label4);
            this.groupBoxProduct.Controls.Add(this.textBox2);
            this.groupBoxProduct.Controls.Add(this.label3);
            this.groupBoxProduct.Controls.Add(this.textBoxCode);
            this.groupBoxProduct.Controls.Add(this.label2);
            this.groupBoxProduct.Controls.Add(this.comboBox1);
            this.groupBoxProduct.Controls.Add(this.label1);
            this.groupBoxProduct.Font = new System.Drawing.Font("TH Sarabun New", 14F);
            this.groupBoxProduct.Location = new System.Drawing.Point(20, 70);
            this.groupBoxProduct.Size = new System.Drawing.Size(350, 330);
            this.groupBoxProduct.Text = "ข้อมูลสินค้า";

            // btnAdd
            this.btnAdd.Location = new System.Drawing.Point(100, 280);
            this.btnAdd.Size = new System.Drawing.Size(150, 35);
            this.btnAdd.Text = "เพิ่มสินค้า";

            // textBoxQty
            this.textBoxQty.Location = new System.Drawing.Point(120, 235);
            this.textBoxQty.Size = new System.Drawing.Size(200, 29);

            // label5
            this.label5.Location = new System.Drawing.Point(20, 238);
            this.label5.Text = "จำนวน";

            // textBox3
            this.textBox3.Location = new System.Drawing.Point(120, 195);
            this.textBox3.Size = new System.Drawing.Size(200, 29);

            // label4
            this.label4.Location = new System.Drawing.Point(20, 198);
            this.label4.Text = "ราคา";

            // textBox2
            this.textBox2.Location = new System.Drawing.Point(120, 155);
            this.textBox2.Size = new System.Drawing.Size(200, 29);

            // label3
            this.label3.Location = new System.Drawing.Point(20, 158);
            this.label3.Text = "หมวดหมู่";

            // textBoxCode
            this.textBoxCode.Location = new System.Drawing.Point(120, 115);
            this.textBoxCode.Size = new System.Drawing.Size(200, 29);

            // label2
            this.label2.Location = new System.Drawing.Point(20, 118);
            this.label2.Text = "รหัสสินค้า";

            // comboBox1
            this.comboBox1.Location = new System.Drawing.Point(120, 75);
            this.comboBox1.Size = new System.Drawing.Size(200, 31);

            // label1
            this.label1.Location = new System.Drawing.Point(20, 78);
            this.label1.Text = "ชื่อสินค้า";

            // groupBoxCart
            this.groupBoxCart.Controls.Add(this.dataGridView1);
            this.groupBoxCart.Font = new System.Drawing.Font("TH Sarabun New", 14F);
            this.groupBoxCart.Location = new System.Drawing.Point(390, 70);
            this.groupBoxCart.Size = new System.Drawing.Size(480, 330);
            this.groupBoxCart.Text = "รายการขาย";

            // dataGridView1
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.MultiSelect = false;

            // lblTotal
            this.lblTotal.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.lblTotal.Location = new System.Drawing.Point(400, 420);
            this.lblTotal.Text = "ยอดรวม: 0.00";

            // lblVat
            this.lblVat.Font = new System.Drawing.Font("TH Sarabun New", 16F, System.Drawing.FontStyle.Bold);
            this.lblVat.Location = new System.Drawing.Point(400, 450);
            this.lblVat.Text = "ภาษี 7%: 0.00";

            // lblGrandTotal
            this.lblGrandTotal.Font = new System.Drawing.Font("TH Sarabun New", 18F, System.Drawing.FontStyle.Bold);
            this.lblGrandTotal.Location = new System.Drawing.Point(400, 480);
            this.lblGrandTotal.Text = "ยอดสุทธิ: 0.00";

            // btnDelete
            this.btnDelete.Location = new System.Drawing.Point(390, 520);
            this.btnDelete.Size = new System.Drawing.Size(150, 40);
            this.btnDelete.Text = "ลบรายการ";

            // btnPrintPdf
            this.btnPrintPdf.Location = new System.Drawing.Point(720, 520);
            this.btnPrintPdf.Size = new System.Drawing.Size(150, 40);
            this.btnPrintPdf.Text = "ปริ้นใบเสร็จ PDF";

            // Form1
            this.ClientSize = new System.Drawing.Size(900, 580);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnPrintPdf);
            this.Controls.Add(this.lblGrandTotal);
            this.Controls.Add(this.lblVat);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.groupBoxCart);
            this.Controls.Add(this.groupBoxProduct);
            this.Controls.Add(this.lblTitle);
            this.Text = "ระบบร้านขายยา";

            this.groupBoxProduct.ResumeLayout(false);
            this.groupBoxProduct.PerformLayout();
            this.groupBoxCart.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox groupBoxProduct;
        private System.Windows.Forms.GroupBox groupBoxCart;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBoxCode;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBoxQty;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrintPdf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblGrandTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}
