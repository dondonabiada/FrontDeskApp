namespace FrontDeskApp.WinApp
{
    partial class frmStoreBox
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Customers = new System.Windows.Forms.ComboBox();
            this.customersControllerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StorageBoxes = new System.Windows.Forms.ComboBox();
            this.btnStore = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.BoxTypes = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customersControllerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Storage Box";
            // 
            // Customers
            // 
            this.Customers.DataSource = this.customersControllerBindingSource;
            this.Customers.FormattingEnabled = true;
            this.Customers.Location = new System.Drawing.Point(129, 23);
            this.Customers.Name = "Customers";
            this.Customers.Size = new System.Drawing.Size(243, 23);
            this.Customers.TabIndex = 2;
               // 
            // StorageBoxes
            // 
            this.StorageBoxes.FormattingEnabled = true;
            this.StorageBoxes.Location = new System.Drawing.Point(129, 100);
            this.StorageBoxes.Name = "StorageBoxes";
            this.StorageBoxes.Size = new System.Drawing.Size(243, 23);
            this.StorageBoxes.TabIndex = 3;
            // 
            // btnStore
            // 
            this.btnStore.Location = new System.Drawing.Point(209, 141);
            this.btnStore.Name = "btnStore";
            this.btnStore.Size = new System.Drawing.Size(75, 23);
            this.btnStore.TabIndex = 4;
            this.btnStore.Text = "Store";
            this.btnStore.UseVisualStyleBackColor = true;
            this.btnStore.Click += new System.EventHandler(this.btnStore_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(297, 141);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // BoxTypes
            // 
            this.BoxTypes.FormattingEnabled = true;
            this.BoxTypes.Items.AddRange(new object[] {
            "SMALL",
            "MEDIUM",
            "LARGE"});
            this.BoxTypes.Location = new System.Drawing.Point(129, 61);
            this.BoxTypes.Name = "BoxTypes";
            this.BoxTypes.Size = new System.Drawing.Size(243, 23);
            this.BoxTypes.TabIndex = 7;
            this.BoxTypes.SelectedIndexChanged += new System.EventHandler(this.BoxTypes_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Box Type";
            // 
            // frmStoreBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 192);
            this.Controls.Add(this.BoxTypes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnStore);
            this.Controls.Add(this.StorageBoxes);
            this.Controls.Add(this.Customers);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStoreBox";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Store Box";
            this.Load += new System.EventHandler(this.frmStoreBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customersControllerBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private ComboBox Customers;
        private ComboBox StorageBoxes;
        private Button btnStore;
        private Button btnCancel;
        private BindingSource customersControllerBindingSource;
        private ComboBox BoxTypes;
        private Label label3;
    }
}